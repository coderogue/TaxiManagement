using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace TaxiManager.Model
{
    class VehicleCategoryModel : Classes.CDBase
    {
        private const string SELCMD = "SELECT * FROM vehicle_category WHERE rec_status = TRUE ";
        private const string INSCMD = "INSERT INTO vehicle_category (vcat_desc, c_by, c_date, u_by, u_date, rec_status) " +
                                      "VALUES ('?vcat_desc', ?c_by, NOW(), ?c_by, NOW(), TRUE)";
        private const string UPDCMD = "UPDATE vehicle_category SET vcat_desc = '?vcat_desc', u_by = ?u_by, u_date = NOW() " +
                                      "WHERE vcatid = ?vcatid";
        private const string DELCMD = "UPDATE vehicle_category SET rec_status = FALSE WHERE vcatid = ?vcatid";


        protected DataTable GetCats(string clauses)
        {
            return GetDTable(SELCMD + clauses);
        }

        public int InsertCategory(string vcat_desc, int c_by)
        {
            string Insert = INSCMD;
            object result = 0;
            Insert = Insert.Replace("?vcat_desc", vcat_desc);
            Insert = Insert.Replace("?c_by", c_by.ToString());

            result = ExecuteCommand(Insert);
            if (result is int)
                return (int)result;
            else
                if (result.ToString().StartsWith("Duplicate"))
                    RecoverCategory(vcat_desc);
                else
                    MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        public int UpdateCategory(string vcat_desc, int u_by, int vcatid)
        {
            string Update = UPDCMD;
            object result = 0;
            Update = Update.Replace("?vcat_desc", vcat_desc);
            Update = Update.Replace("?u_by", u_by.ToString());
            Update = Update.Replace("?vcatid", vcatid.ToString());

            result = ExecuteCommand(Update);
            if (result is int)
                return (int)result;
            else
                MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        public int DeleteCategory(int vcatid)
        {
            string Delete = DELCMD;
            object result = 0;
            Delete = Delete.Replace("?vcatid", vcatid.ToString());

            result = ExecuteCommand(Delete);
            if (result is int)
                return (int)result;
            else
                MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        private void RecoverCategory(string vcat_desc) {
            string UpdateQuery = "UPDATE vehicle_category SET rec_status = TRUE WHERE vcat_desc = '" + vcat_desc + "'";
            ExecuteCommand(UpdateQuery);
        }
    }
}
