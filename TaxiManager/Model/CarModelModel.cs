using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace TaxiManager.Model
{
    class CarModelModel : Classes.CDBase
    {
        public CarModelModel() { }

        protected string SELCMD = "SELECT * FROM made_model WHERE rec_status = true ";
        protected string INSCMD = "INSERT INTO made_model (mm_cmid, mm_name, c_by, c_date, u_by, u_date, rec_status) " +
                                  "VALUES (?mm_cmid, '?mm_name', ?c_by, NOW(), ?c_by, NOW(), TRUE)";
        protected string UPDCMD = "UPDATE made_model SET mm_cmid = ?mm_cmid, mm_name = '?mm_name', u_by = ?u_by, u_date = NOW() " +
                                  "WHERE mmid = ?mmid";
        protected string DELCMD = "UPDATE made_model SET rec_status = FALSE " +
                                  "WHERE mmid = ?mmid";


        public DataTable GetCarModels(string Clauses)
        {
            DataTable DT = GetDTable(SELCMD + Clauses);
            return DT;
        }

        public int InsertRow(int mm_cmid, string mm_name, int c_by)
        {
            string INSERT = INSCMD;
            object result = 0;
            INSERT = INSERT.Replace("?mm_cmid", mm_cmid.ToString());
            INSERT = INSERT.Replace("?mm_name", mm_name);
            INSERT = INSERT.Replace("?c_by", c_by.ToString());

            result = ExecuteCommand(INSERT);
            if (result is int)
                return (int)result;
            else
            {
                if (result.ToString().StartsWith("Duplicate"))
                    RecoverRow(mm_cmid, mm_name, c_by);
                else
                    MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
                return 0;
            }
        }

        public int UpdateRow(int mm_cmid, string mm_name, int u_by, int mmid)
        {
            string Update = UPDCMD;
            object result = 0;
            Update = Update.Replace("?mm_cmid", mm_cmid.ToString());
            Update = Update.Replace("?mm_name", mm_name);
            Update = Update.Replace("?u_by", u_by.ToString());
            Update = Update.Replace("?mmid", mmid.ToString());

            result = ExecuteCommand(Update);
            if (result is int)
                return (int)result;
            else
            {
                MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
                return 0;
            }
        }

        public int DeleteRow(int mmid)
        {
            string Delete = DELCMD;
            object result = 0;
            Delete = Delete.Replace("?mmid", mmid.ToString());

            result = ExecuteCommand(Delete);
            if (result is int)
                return (int)result;
            else
            {
                MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
                return 0;
            }
        }

        private void RecoverRow(int mm_cmid, string mm_name, int u_by)
        {
            string UpdateQuery = "UPDATE made_model SET rec_status = TRUE, u_by = " + u_by + ", u_date = NOW() WHERE mm_cmid = " + mm_cmid + " AND mm_name = '" + mm_name + "'";
            ExecuteCommand(UpdateQuery);
        }
    }
}
