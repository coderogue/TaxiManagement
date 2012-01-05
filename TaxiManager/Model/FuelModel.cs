using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TaxiManager.Model
{
    class FuelModel : Classes.CDBase
    {
        private const string SELCMD = "SELECT * FROM fuel_type WHERE rec_status = TRUE ";
        private const string INSCMD = "INSERT INTO fuel_type (ft_desc, c_by, c_date, u_by, u_date, rec_status) " +
                                      "VALUES ('?ft_desc', ?c_by, NOW(), ?c_by, NOW(), TRUE)";
        private const string UPDCMD = "UPDATE fuel_type SET ft_desc = '?ft_desc', u_by = ?u_by, u_date = NOW() " +
                                      "WHERE ftid = ?ftid";
        private const string DELCMD = "UPDATE fuel_type SET rec_status = FALSE WHERE ftid = ?ftid";

        protected DataTable GetFuelTable(string Clauses)
        {
            return GetDTable(SELCMD + Clauses);
        }

        public int InsertFuelType(string ft_desc, int c_by)
        {
            string Insert = INSCMD;
            object result = 0;
            Insert = Insert.Replace("?ft_desc", ft_desc);
            Insert = Insert.Replace("?c_by", c_by.ToString());
            
            result = ExecuteCommand(Insert);

            if (result is int)
                return (int) result;
            else {
                if (result.ToString().StartsWith("Duplicate"))
                    RecoverFuelType(ft_desc, c_by);
                else
                    System.Windows.Forms.MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
                return 0;
            }

        }

        public int UpdateFuelType(string ft_desc, int u_by, int ftid) {
            string Update = UPDCMD;
            object result = 0;
            Update = Update.Replace("?ft_desc", ft_desc);
            Update = Update.Replace("?u_by", u_by.ToString());
            Update = Update.Replace("?ftid", ftid.ToString());

            result = ExecuteCommand(Update);
            if (result is int)
                return (int)result;
            else
            {
                System.Windows.Forms.MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
                return 0;
            }

        }

        public void RecoverFuelType(string ft_desc, int u_by)
        {
            string UpdateQuery = "UPDATE fuel_type SET rec_status = TRUE, u_by = " + u_by + ", u_date = NOW() WHERE ft_desc = '" + ft_desc + "'";
            ExecuteCommand(UpdateQuery);
        }

        public int DeleteFuelType(int ftid)
        {
            string Delete = DELCMD;
            object result = 0;
            Delete = Delete.Replace("?ftid", ftid.ToString());

            result = ExecuteCommand(Delete);
            if (result is int)
                return (int)result;
            else
            {
                System.Windows.Forms.MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
                return 0;
            }
        }
    }
}
