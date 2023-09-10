﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeperSystem
{
    public class President
    {
        public static DataTable SearchPresidents(string lastname)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("PresidentGet");
            SQLUtility.SetParamValue(cmd, "@LastName", lastname);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int presidentid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("PresidentGet");
            SQLUtility.SetParamValue(cmd, "@PresidentId", presidentid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable GetPartyList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("PartyGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void Save(DataTable dtpresident)
        {
            if(dtpresident.Rows.Count == 0)
            {
                throw new Exception("Cannot call President save method because there are no rows in the table."); 
            }
            DataRow r = dtpresident.Rows[0];
            SQLUtility.SaveDataRow(r, "PresidentUpdate");
        }
        public static void Delete(DataTable dtpresident)
        {
            int id = (int)dtpresident.Rows[0]["PresidentId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("PresidentDelete");
            SQLUtility.SetParamValue(cmd, "@PresidentId", id);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
