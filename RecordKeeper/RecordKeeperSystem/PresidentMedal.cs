using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeperSystem
{
    public class PresidentMedal
    {
        public static DataTable LoadByPresidentId(int presidentid)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSQLCommand("PresidentMedalGet");
            cmd.Parameters["@PresidentId"].Value = presidentid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
    }
}
