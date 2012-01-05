using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace TaxiManager.Model
{
    class BodyTypeModel : Classes.CDBase
    {
        protected const string SELCMD = "SELECT * FROM body_type WHERE rec_status = TRUE ";
        protected const string INSCMD = "INSERT INTO body_type (bt_desc, c_by, c_date, u_by, u_date, rec_status) " +
                                        "VALUES ('?bt_desc', ?c_by, NOW(), ?c_by, NOW(), TRUE)";
        protected const string UPDCMD = "UPDATE body_type SET bt_desc = '?bt_desc', u_by = ?u_by, u_date = NOW() " +
                                        "WHERE btid = ?btid";
        protected const string DELCMD = "UPDATE body_type SET rec_status = FALSE WHERE btid = ?btid";


        //Functions
        protected DataTable GetBodyTypes(string Clauses)
        {
            return GetDTable(SELCMD + Clauses);
        }

        public int InsertBodyType(string bt_desc, int c_by)
        {
            string Insert = INSCMD;
            object result = 0;
            Insert = Insert.Replace("?bt_desc", bt_desc);
            Insert = Insert.Replace("?c_by", c_by.ToString());

            result = ExecuteCommand(Insert);
            if (result is int)
                return (int)result;
            else
                if (result.ToString().StartsWith("Duplicate"))
                    RecoverBodyType(bt_desc, c_by);
                else
                    MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        public int UpdateBodyType(string bt_desc, int u_by, int btid)
        {
            string Update = UPDCMD;
            object result = 0;
            Update = Update.Replace("?bt_desc", bt_desc);
            Update = Update.Replace("?u_by", u_by.ToString());
            Update = Update.Replace("?btid", btid.ToString());

            result = ExecuteCommand(Update);
            if (result is int)
                return (int)result;
            else
                MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        public int DeleteBodyType(int btid)
        {
            string Delete = DELCMD;
            object result = 0;
            Delete = Delete.Replace("?btid", btid.ToString());

            result = ExecuteCommand(Delete);
            if (result is int)
                return (int)result;
            else
                MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        private void RecoverBodyType(string bt_desc, int u_by)
        {
            string UpdateQuery = "UPDATE body_type SET rec_status = TRUE, u_by = " + u_by + ", u_date = NOW() WHERE bt_desc = '" + bt_desc + "'";
            ExecuteCommand(UpdateQuery);
        }
    }
}
