using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace TaxiManager.Model
{
    class OwnerStatusModel : Classes.CDBase
    {
        private const string SELCMD = "SELECT * FROM owner_status WHERE rec_status = TRUE ";
        private const string INSCMD = "INSERT INTO owner_status (os_desc, c_by, c_date, u_by, u_date, rec_status) " +
                                      "VALUES ('?os_desc', ?c_by, NOW(), ?c_by, NOW(), TRUE)";
        private const string UPDCMD = "UPDATE owner_status SET os_desc = '?os_desc', u_by = ?u_by, u_date = NOW() " +
                                      "WHERE osid = ?osid";
        private const string DELCMD = "UPDATE owner_status SET rec_status = FALSE WHERE osid = ?osid";

        protected DataTable GetOwerStatusList(string Clauses)
        {
            return GetDTable(SELCMD + Clauses);
        }

        public int InsertOwnerStatus(string os_desc, int c_by)
        {
            object result = 0;
            string Insert = INSCMD;
            Insert = Insert.Replace("?os_desc", os_desc);
            Insert = Insert.Replace("?c_by", c_by.ToString());

            result = ExecuteCommand(Insert);
            if (result is int)
                return (int)result;
            else
                if (result.ToString().StartsWith("Duplicate"))
                    RecoverOwnerStatus(os_desc, c_by);
                else
                    MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        public int UpdateOwnerStatus(string os_desc, int u_by, int osid)
        {
            object result = 0;
            string Update = UPDCMD;
            Update = Update.Replace("?os_desc", os_desc);
            Update = Update.Replace("?u_by", u_by.ToString());
            Update = Update.Replace("?osid", osid.ToString());

            result = ExecuteCommand(Update);
            return Classes.CConstant.GetResult(result);
        }

        public int DeleteOwnerStatus(int osid)
        {
            object result = 0;
            string Delete = DELCMD;
            Delete = Delete.Replace("?osid", osid.ToString());

            result = ExecuteCommand(Delete);
            return Classes.CConstant.GetResult(result);
        }

        private void RecoverOwnerStatus(string os_desc, int u_by)
        {
            string UpdateQuery = "UPDATE owner_status SET rec_status = TRUE, u_by = " + u_by + ", u_date = NOW() WHERE os_desc = '" + os_desc + "'";
            ExecuteCommand(UpdateQuery);
        }
    }
}
