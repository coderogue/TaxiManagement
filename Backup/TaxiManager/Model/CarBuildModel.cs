using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TaxiManager.Model
{
    class CarBuildModel : Classes.CDBase
    {
        protected const string SELCMD = "SELECT * FROM car_made WHERE rec_status = true ";
        protected const string INSCMD = "INSERT INTO car_made (cm_name, c_by, c_date, u_by, u_date, rec_status) " +
                                        "VALUES (?cm_name, ?c_by, NOW(), ?c_by, NOW(), ?rec_status)";
        protected const string UPDCMD = "UPDATE car_made SET c_name = ?c_name, " +
                                        "u_by = ?u_by, " +
                                        "u_date = NOW() " +
                                        "WHERE cmid = ?cmid";
        protected const string DELCMD = "UPDATE car_made SET rec_status = false, u_by = ?u_by, u_date = NOW() " +
                                        "WHERE cmid = ?cmid";

        protected DataTable GetCarMakes()
        {
            return GetDTable(SELCMD);
        }

        protected DataTable GetCarMakes(string Clauses)
        {
            return GetDTable(SELCMD + Clauses);
        }

        protected int InsertCarMake(string cm_name, int c_by)
        {
            string Insert = INSCMD;
            Insert = Insert.Replace("?cm_name", cm_name);
            Insert = Insert.Replace("?c_by", c_by.ToString());

            return ExecuteCommand(Insert);
        }

        protected int UpdateCarMake(string cm_name, int u_by, int cmid)
        {
            string Update = UPDCMD;
            Update = Update.Replace("?cm_name", cm_name);
            Update = Update.Replace("?u_by", u_by.ToString());
            Update = Update.Replace("?cmid", cmid.ToString());

            return ExecuteCommand(Update);
        }

        protected int DeleteCarMake(int cmid, int u_by)
        {
            string Delete = DELCMD;
            Delete = Delete.Replace("?cmid", cmid.ToString());
            Delete = Delete.Replace("?u_by", u_by.ToString());

            return ExecuteCommand(Delete);
        }
    }
}
