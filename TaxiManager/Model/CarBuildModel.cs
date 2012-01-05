using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace TaxiManager.Model
{
    class CarBuildModel : Classes.CDBase
    {
        protected const string SELCMD = "SELECT * FROM car_made WHERE rec_status = true ";
        protected const string INSCMD = "INSERT INTO car_made (cm_name, c_by, c_date, u_by, u_date, rec_status) " +
                                        "VALUES ('?cm_name', ?c_by, NOW(), ?c_by, NOW(), TRUE)";
        protected const string UPDCMD = "UPDATE car_made SET cm_name = '?cm_name', " +
                                        "u_by = ?u_by, " +
                                        "u_date = NOW() " +
                                        "WHERE cmid = ?cmid";
        protected const string DELCMD = "UPDATE car_made SET rec_status = false, u_by = ?u_by, u_date = NOW() " +
                                        "WHERE cmid = ?cmid";
        protected const string CNTCMD = "SELECT COUNT(*) FROM car_made WHERE rec_status = true ";

        protected DataTable GetCarMakes()
        {
            return GetDTable(SELCMD);
        }

        protected DataTable GetCarMakes(string Clauses)
        {
            return GetDTable(SELCMD + Clauses);
        }

        protected int CountCarMakes()
        {
            return Convert.ToInt32(GetSCALAR(CNTCMD));
        }

        protected int CountCarMakes(string Clauses)
        {
            return Convert.ToInt32(GetSCALAR(CNTCMD + Clauses));;
        }

        protected int InsertCarMake(string cm_name, int c_by)
        {
            string Insert = INSCMD;
            object result = 0;
            Insert = Insert.Replace("?cm_name", cm_name);
            Insert = Insert.Replace("?c_by", c_by.ToString());

            result = ExecuteCommand(Insert);
            if (result is int)
                return (int)result;
            else
                if (result.ToString().StartsWith("Duplicate"))
                    RecoverCarMake(cm_name, c_by);
                else
                    MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        protected int UpdateCarMake(string cm_name, int u_by, int cmid)
        {
            string Update = UPDCMD;
            object result = 0;
            Update = Update.Replace("?cm_name", cm_name);
            Update = Update.Replace("?u_by", u_by.ToString());
            Update = Update.Replace("?cmid", cmid.ToString());

            result = ExecuteCommand(Update);
            if (result is int)
                return (int)result;
            else
                MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        protected int DeleteCarMake(int cmid, int u_by)
        {
            string Delete = DELCMD;
            object result = 0;
            Delete = Delete.Replace("?cmid", cmid.ToString());
            Delete = Delete.Replace("?u_by", u_by.ToString());

            result = ExecuteCommand(Delete);
            if (result is int)
                return (int)result;
            else
                MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        private void RecoverCarMake(string cm_name, int u_by)
        {
            string UpdateQuery = "UPDATE car_made SET rec_status = TRUE, u_by = " + u_by + ", u_date = NOW() WHERE cm_name = '" + cm_name + "'";
            ExecuteCommand(UpdateQuery);
        }
    }
}
