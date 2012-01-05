using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace TaxiManager.Model
{
    class ClassTypeModel : Classes.CDBase
    {
        private const string SELCMD = "SELECT * FROM class_type WHERE rec_status = TRUE";
        private const string INSCMD = "INSERT INTO class_type (ct_desc, c_by, c_date, u_by, u_date, rec_status) " +
                                      "VALUES ('?ct_desc', ?c_by, NOW(), ?c_by, NOW(), TRUE)";
        private const string UPDCMD = "UPDATE class_type SET ct_desc = '?ct_desc', u_by = ?u_by, u_date = NOW() " +
                                      "WHERE ctid = ?ctid";
        private const string DELCMD = "UPDATE class_type SET rec_status = FALSE WHERE ctid = ?ctid";


        protected DataTable GetClassList(string clauses)
        {
            return GetDTable(SELCMD + clauses);
        }

        public int InsertClassType(string ct_desc, int c_by)
        {
            object result = 0;
            string Insert = INSCMD;
            Insert = Insert.Replace("?ct_desc", ct_desc);
            Insert = Insert.Replace("?c_by", c_by.ToString());

            result = ExecuteCommand(Insert);

            if (result is int)
                return (int)result;
            else
                if (result.ToString().StartsWith("Duplicate"))
                    RecoverClassType(ct_desc, c_by);
                else
                    MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        public int UpdateClassType(string ct_desc, int u_by, int ctid)
        {
            object result = 0;
            string Update = UPDCMD;
            Update = Update.Replace("?ct_desc", ct_desc);
            Update = Update.Replace("?u_by", u_by.ToString());
            Update = Update.Replace("?ctid", ctid.ToString());

            result = ExecuteCommand(Update);
            return Classes.CConstant.GetResult(result);
        }

        public int DeleteClassType(int ctid)
        {
            object result = 0;
            string Delete = DELCMD;
            Delete = Delete.Replace("?ctid", ctid.ToString());

            result = ExecuteCommand(Delete);
            return Classes.CConstant.GetResult(result);
        }

        private void RecoverClassType(string ct_desc, int u_by)
        {
            string UpdateQuery = "UPDATE class_type SET rec_status = TRUE, u_by = " + u_by + ", u_date = NOW() WHERE ct_desc ='" + ct_desc + "'";
            ExecuteCommand(UpdateQuery);
        }
    }
}
