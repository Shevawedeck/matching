using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using System.Data;

namespace RecordKeeperTest
{
    public class PresidentTest
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=RecordKeeperDB;Trusted_Connection=true");
        }
        [Test] 
        [TestCase("Sam", "Smith", "2035-01-01", 2080, 2084)]
        public void InsertNewPresident(string firstname, string lastname, DateTime dateborn, int termstart, int termend) 
        {
            DataTable dt = SQLUtility.GetDataTable("select * from president where presidentid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int partyid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 partyid from party");
            Assume.That(partyid > 0, "cant run test - no parties in db");
            int maxnum = SQLUtility.GetFirstColumnFirstRowValue("select max (num) from president");
            maxnum = maxnum + 1;
            TestContext.WriteLine("insert president with num = " + maxnum);
            r["partyid"] = partyid;
            r["Num"] = maxnum;
            r["FirstName"] = firstname;
            r["LastName"] = lastname;
            r["DateBorn"] = dateborn;
            r["TermStart"] = termstart;
            r["TermEnd"] = termend;
            President.Save(dt);
            int newnum = SQLUtility.GetFirstColumnFirstRowValue("select * from president where num = " + maxnum);
            int pkid = 0;
            if (r["PresidentId"] != DBNull.Value)
            {
                pkid = (int)r["PresidentId"];
            }
            Assert.IsTrue(newnum > 0, "president with num = " + maxnum + "is not found in db");
            Assert.IsTrue(pkid > 0, "primary key not updated in datatable");
            TestContext.WriteLine("president with " + maxnum + " is found in db with pk value = " + newnum);
            TestContext.WriteLine("new primary key = " + pkid);
        }
        [Test]
        public void ChangeExistingPresidentTermStart()
        {
            int presidentid = GetExistingPresidentId();
            Assume.That(presidentid > 0, "no presidents in DB, cant run test");
            int TermStart = SQLUtility.GetFirstColumnFirstRowValue("select TermStart from president where presidentid = " + presidentid);
            TestContext.WriteLine("TermStart for presidentid " + presidentid + " is " + TermStart);
            TermStart = TermStart - 1;
            TestContext.WriteLine("change TermStart to " + TermStart);
            DataTable dt = President.Load(presidentid);
            
            dt.Rows[0]["TermStart"] = TermStart;
            President.Save(dt);
            
            int newTermStart = SQLUtility.GetFirstColumnFirstRowValue("select TermStart from president where presidentid = " + presidentid);
            Assert.IsTrue(newTermStart == TermStart, "TermStart for president (" + presidentid + ") = " + newTermStart );
            TestContext.WriteLine("TermStart for president (" + presidentid + ") = " + newTermStart);
        }
        [Test]
        public void ChangeExistingPresidentToInvalidTermStart()
        {
            int presidentid = GetExistingPresidentId();
            int termstart = 0;
            Assume.That(presidentid > 0, "no presidents in DB, cant run test");
            int termend = SQLUtility.GetFirstColumnFirstRowValue("select termend from president where presidentid = " + presidentid);
            
            TestContext.WriteLine("termend for presidentid " + presidentid + " is " + termend);
            termstart = termstart + 1;
            TestContext.WriteLine("change TermStart to " + termstart);
           
            DataTable dt = President.Load(presidentid);
            dt.Rows[0]["TermStart"] = termstart;
            Exception ex = Assert.Throws<Exception>(() => President.Save(dt));
            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void ChangeExistingPresidentToInvalidNum()
        {
            int presidentid = GetExistingPresidentId();
            Assume.That(presidentid > 0, "no presidents in DB, cant run test");
            int num = SQLUtility.GetFirstColumnFirstRowValue("select top 1 num from president where presidentid <> " + presidentid);
            int currentnum = SQLUtility.GetFirstColumnFirstRowValue("select top 1 num from president where presidentid = " + presidentid);
            Assume.That(num > 0, "cannot run test because there is not other president record in the table");
            TestContext.WriteLine("change presidentid " + presidentid + " num from " + currentnum + " to " + num + " which belongs to a diff president " );    
            DataTable dt = President.Load(presidentid);
            dt.Rows[0]["num"] = num;
            Exception ex = Assert.Throws<Exception>(() => President.Save(dt));
            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void DeletePresident()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 p.presidentid, LastName, Num from president p left join executiveorder e on p.PresidentId = e.PresidentId left join PresidentMedal pm on pm.PresidentId = p.PresidentId where e.executiveorderid is null and pm.MedalId is null");
            int presidentid = 0;
            string prezdesc = "";
            if(dt.Rows.Count > 0)
            {
                presidentid = (int)dt.Rows[0]["presidentid"];
                prezdesc = dt.Rows[0]["Num"] + " " + dt.Rows[0]["LastName"];
            }
            Assume.That(presidentid > 0, "no presidents without executive order in DB, cant run test");
            TestContext.WriteLine("existing president without executive order with id = " + presidentid + " " + prezdesc);
            TestContext.WriteLine("ensure that app can delete " + presidentid);
            President.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from president where presidentid = " + presidentid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with presidentid " + presidentid + " exists in db");
            TestContext.WriteLine("record with presidentid " + presidentid + " does not exist in database");
        }
        [Test]
        public void DeletePresidentWithUpheldExecutiveOrder()
        {
            string sql = @"select top 1 p.PresidentId, Num, LastName from President p join executiveorder e on e.presidentid = e.PresidentId where e.Upheldbycourt = 1";
            DataTable dt = SQLUtility.GetDataTable(sql);
            int presidentid = 0;
            string prezdesc = "";
            if (dt.Rows.Count > 0)
            {
                presidentid = (int)dt.Rows[0]["presidentid"];
                prezdesc = dt.Rows[0]["Num"] + " " + dt.Rows[0]["LastName"];
            }
            Assume.That(presidentid > 0, "no presidents with upheld executive orders in DB, cant run test");
            TestContext.WriteLine("existing president with executive order with id = " + presidentid + " " + prezdesc);
            TestContext.WriteLine("ensure that app cannot delete " + presidentid);
            Exception ex = Assert.Throws<Exception>(() => President.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void LoadPresident()
        {
            int presidentid = GetExistingPresidentId();
            Assume.That(presidentid > 0, "no presidents in DB, cant run test");
            TestContext.WriteLine("existing president with id = " + presidentid);
            TestContext.WriteLine("ensure that app loads president " + presidentid);
            DataTable dt = President.Load(presidentid);
            int loadedid = 0;
            if(dt.Rows.Count > 0)
            {
                loadedid = (int)dt.Rows[0]["presidentid"];
            }
            Assert.IsTrue(loadedid == presidentid, loadedid + " <> " + presidentid);
            TestContext.WriteLine("loaded president (" + loadedid + ")");
        }
        [Test]
        public void SearchPresident()
        {
            string criteria = "a";
            int num = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from president where lastname like '%" + criteria + "%'");
            Assume.That(num > 0, "There are no presidents that match the search for " + num);
            TestContext.WriteLine(num + " presidents that match the search for " + criteria);
            TestContext.WriteLine("ensure that search returns " + num + "rows");
            DataTable dt = President.SearchPresidents(criteria);
            int results = dt.Rows.Count;
            Assert.IsTrue(results == num, "results of president search does not match num of presidents, " + results + " <> " + num);
            TestContext.WriteLine("number of rows returned by president search is " + results);
        }
        [Test]
        public void GetListOfParties()
        {
            int partycount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from party"); 
            Assume.That(partycount > 0, "No parties in DB; cant test");
            TestContext.WriteLine("Number of parties in DB = " + partycount);
            TestContext.WriteLine("ensure that Number of Rows return by app = " + partycount);
            DataTable dt = President.GetPartyList();

            Assert.IsTrue(dt.Rows.Count == partycount, "num rows returned (" + dt.Rows.Count + ") <> " + partycount);
            TestContext.WriteLine("Number of Rows in Party returned by app = " + dt.Rows.Count);
        }
        private int GetExistingPresidentId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 presidentid from president");
        }
    }
}