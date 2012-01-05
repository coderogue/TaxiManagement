using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace TaxiManager.Model
{
    class TaxiModel : Classes.CDBase
    {

        private const string SELCMD = "SELECT taxi.*, cm_name, mm_name, ft_desc, colour_desc, bt_desc FROM taxi " + 
                                      "INNER JOIN car_made ON taxi_made = cmid " + 
                                      "INNER JOIN made_model ON taxi_model = mmid " +
                                      "INNER JOIN fuel_type ON taxi_fuel = ftid " +
                                      "INNER JOIN colours ON taxi_colour = colourid " +
                                      "INNER JOIN class_type ON taxi_use = ctid " +
                                      "INNER JOIN body_type ON taxi_body = btid " +
                                      "WHERE 1=1 ";
        private const string INSCMD = "INSERT INTO taxi (taxi_regno, taxi_owner, taxi_oaddress, taxi_engineno, taxi_casisno, taxi_made, taxi_model, taxi_epower, taxi_fuel, taxi_colour, taxi_use, taxi_body, taxi_builtyr, taxi_regdate, taxi_ostatus, taxi_seatno, taxi_lrate6, taxi_lrate12, taxi_cono, c_by, c_date, u_by, u_date) " +
                                      "VALUES ('?taxi_regno', '?taxi_owner', '?taxi_oaddress', '?taxi_engineno', '?taxi_casisno', ?taxi_made, ?taxi_model, '?taxi_epower', ?taxi_fuel, ?taxi_colour, ?taxi_use, ?taxi_body, ?taxi_builtyr, '?taxi_regdate', ?taxi_ostatus, ?taxi_seatno, ?taxi_lrate6, ?taxi_lrate12, '?taxi_cono', ?c_by, NOW(), ?c_by, NOW())";
        private const string UPDCMD = "UPDATE taxi SET " +
                                        "taxi_owner = '?taxi_owner', " +
                                        "taxi_oaddress = '?taxi_oaddress', " +
                                        "taxi_engineno = '?taxi_engineno', " +
                                        "taxi_casisno = '?taxi_casisno', " +
                                        "taxi_made = ?taxi_made, " +
                                        "taxi_model = ?taxi_model, " +
                                        "taxi_epower = '?taxi_epower', " +
                                        "taxi_fuel = ?taxi_fuel, " +
                                        "taxi_colour = ?taxi_colour, " +
                                        "taxi_use = ?taxi_use, " +
                                        "taxi_body = ?taxi_body, " +
                                        "taxi_builtyr = ?taxi_builtyr, " +
                                        "taxi_regdate = '?taxi_regdate', " +
                                        "taxi_ostatus = ?taxi_ostatus, " + 
                                        "taxi_seatno = ?taxi_seatno, " +
                                        "taxi_lrate6 = ?taxi_lrate6, " +
                                        "taxi_lrate12 = ?taxi_lrate12, " +
                                        "taxi_cono = '?taxi_cono', " +
                                        "u_by = ?u_by, " +
                                        "u_date = NOW() " +
                                      "WHERE taxiid = ?taxiid";
        private const string DELCMD = "DELETE FROM taxi WHERE taxiid = ?taxiid";

        protected DataTable GetTaxiList(string Clauses)
        {
            return GetDTable(SELCMD + Clauses);
        }

        public int InsertTaxi(string taxi_regno, string taxi_owner, string taxi_oaddress, string taxi_engineno, string taxi_casisno, int taxi_made, int taxi_model, 
            string taxi_epower, int taxi_fuel, int taxi_colour, int taxi_use, int taxi_body, int taxi_builtyr, DateTime taxi_regdate, int taxi_ostatus, 
            int taxi_seatno, double taxi_lrate6, double taxi_lrate12, string taxi_cono, int c_by)
        {
            object result = 0;
            string Insert = INSCMD;
            //Replace values
            Insert = Insert.Replace("?taxi_regno", taxi_regno);
            Insert = Insert.Replace("?taxi_owner", taxi_owner);
            Insert = Insert.Replace("?taxi_oaddress", taxi_oaddress);
            Insert = Insert.Replace("?taxi_engineno", taxi_engineno);
            Insert = Insert.Replace("?taxi_casisno", taxi_casisno);
            Insert = Insert.Replace("?taxi_made", taxi_made.ToString());
            Insert = Insert.Replace("?taxi_model", taxi_model.ToString());
            Insert = Insert.Replace("?taxi_epower", taxi_epower);
            Insert = Insert.Replace("?taxi_fuel", taxi_fuel.ToString());
            Insert = Insert.Replace("?taxi_colour", taxi_colour.ToString());
            Insert = Insert.Replace("?taxi_use", taxi_use.ToString());
            Insert = Insert.Replace("?taxi_body", taxi_body.ToString());
            Insert = Insert.Replace("?taxi_builtyr", taxi_builtyr.ToString());
            Insert = Insert.Replace("?taxi_regdate", taxi_regdate.ToString("yyyy-MM-dd"));
            Insert = Insert.Replace("?taxi_ostatus", taxi_ostatus.ToString());
            Insert = Insert.Replace("?taxi_seatno", taxi_seatno.ToString());
            Insert = Insert.Replace("?taxi_lrate6", taxi_lrate6.ToString());
            Insert = Insert.Replace("?taxi_lrate12", taxi_lrate12.ToString());
            Insert = Insert.Replace("?taxi_cono", taxi_cono);
            Insert = Insert.Replace("?c_by", c_by.ToString());

            result = ExecuteCommand(Insert);
            return Classes.CConstant.GetResult(result);
        }

        public int UpdateTaxi(string taxi_owner, string taxi_oaddress, string taxi_engineno, string taxi_casisno, int taxi_made, int taxi_model,
            string taxi_epower, int taxi_fuel, int taxi_colour, int taxi_use, int taxi_body, int taxi_builtyr, DateTime taxi_regdate, int taxi_ostatus,
            int taxi_seatno, double taxi_lrate6, double taxi_lrate12, string taxi_cono, int u_by, int taxiid)
        {
            object result = 0;
            string Update = UPDCMD;
            //Replace values
            Update = Update.Replace("?taxi_owner", taxi_owner);
            Update = Update.Replace("?taxi_oaddress", taxi_oaddress);
            Update = Update.Replace("?taxi_engineno", taxi_engineno);
            Update = Update.Replace("?taxi_casisno", taxi_casisno);
            Update = Update.Replace("?taxi_made", taxi_made.ToString());
            Update = Update.Replace("?taxi_model", taxi_model.ToString());
            Update = Update.Replace("?taxi_epower", taxi_epower);
            Update = Update.Replace("?taxi_fuel", taxi_fuel.ToString());
            Update = Update.Replace("?taxi_colour", taxi_colour.ToString());
            Update = Update.Replace("?taxi_use", taxi_use.ToString());
            Update = Update.Replace("?taxi_body", taxi_body.ToString());
            Update = Update.Replace("?taxi_builtyr", taxi_builtyr.ToString());
            Update = Update.Replace("?taxi_regdate", taxi_regdate.ToString("yyyy-MM-dd"));
            Update = Update.Replace("?taxi_ostatus", taxi_ostatus.ToString());
            Update = Update.Replace("?taxi_seatno", taxi_seatno.ToString());
            Update = Update.Replace("?taxi_lrate6", taxi_lrate6.ToString());
            Update = Update.Replace("?taxi_lrate12", taxi_lrate12.ToString());
            Update = Update.Replace("?taxi_cono", taxi_cono);
            Update = Update.Replace("?u_by", u_by.ToString());
            Update = Update.Replace("?taxiid", taxiid.ToString());

            result = ExecuteCommand(Update);
            return Classes.CConstant.GetResult(result);
        }

        public int DeleteTaxi(int taxiid)
        {
            object result = 0;
            string Delete = DELCMD;
            //Replace values
            Delete = Delete.Replace("?taxiid", taxiid.ToString());

            result = ExecuteCommand(Delete);
            return Classes.CConstant.GetResult(result);
        }
    }
}
