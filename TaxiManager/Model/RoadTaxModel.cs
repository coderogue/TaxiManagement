using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TaxiManager.Model
{
    class RoadTaxModel : Classes.CDBase
    {
        private const string SELCMD = "SELECT rtax.*, taxi.taxi_regno, " +
                                      "CASE WHEN rtax.rtax_dtype = 1 THEN '6 Months' WHEN rtax.rtax_dtype = 2 THEN '12 Months' ELSE '' END AS license_rate " +
                                      "FROM road_tax AS rtax " + 
                                      "INNER JOIN taxi ON taxi.taxiid = rtax.rtax_taxiid " +
                                      "WHERE rtax.rtax_taxiid = ?taxiid @clauses " +
                                      "ORDER BY rtax.rtax_date DESC " +
                                      "LIMIT 10";
        private const string INSCMD = "INSERT INTO road_tax (rtax_date, rtax_dtype, rtax_payment, rtax_taxiid, c_by, c_date, u_by, u_date, rtax_paid) " +
                                      "VALUES (?rtax_date, ?rtax_dtype, ?rtax_payment, ?rtax_taxiid, ?c_by, NOW(), ?c_by, NOW(), ?rtax_paid)";
        private const string UPDCMD = "UPDATE road_tax SET rtax_date = ?rtax_date, rtax_dtype = ?rtax_dtype, rtax_payment = ?rtax_payment, rtax_taxiid = ?rtax_taxiid, " +
                                      "u_by = ?u_by, u_date = NOW(), rtax_paid = ?rtax_paid " +
                                      "WHERE rtaxid = ?rtaxid";
        private const string DELCMD = "DELETE FROM road_tax WHERE rtaxid = ?rtaxid";

        protected DataTable RoadTaxList(int taxiid, string Clauses)
        {
            string Select = SELCMD;
            Select = Select.Replace("?taxiid", taxiid.ToString());
            Select = Select.Replace("@clauses", Clauses);

            return GetDTable(Select);
        }

        public object InsertRoadTax(DateTime rtax_date, int rtax_dtype, double rtax_payment, int rtax_taxiid, int c_by, bool rtax_paid)
        {
            string Insert = INSCMD;
            object result = 0;

            Insert = Insert.Replace("?rtax_date", (rtax_paid) ? "'" + rtax_date.ToString("yyyy-MM-dd") + "'" : "null");
            Insert = Insert.Replace("?rtax_dtype", rtax_dtype.ToString());
            Insert = Insert.Replace("?rtax_payment", rtax_payment.ToString());
            Insert = Insert.Replace("?rtax_taxiid", rtax_taxiid.ToString());
            Insert = Insert.Replace("?c_by", c_by.ToString());
            Insert = Insert.Replace("?rtax_paid", rtax_paid.ToString());

            result = ExecuteCommand(Insert);
            return Classes.CConstant.GetResult(result);
        }

        public object UpdateRoadTax(DateTime rtax_date, int rtax_dtype, double rtax_payment, int rtax_taxiid, int u_by, bool rtax_paid, int rtaxid)
        {
            string Update = UPDCMD;
            object result = 0;

            Update = Update.Replace("?rtax_date", rtax_paid? "'" + rtax_date.ToString("yyyy-MM-dd") + "'": "null");
            Update = Update.Replace("?rtax_dtype", rtax_dtype.ToString());
            Update = Update.Replace("?rtax_payment", rtax_payment.ToString());
            Update = Update.Replace("?rtax_taxiid", rtax_taxiid.ToString());
            Update = Update.Replace("?u_by", u_by.ToString());
            Update = Update.Replace("?rtax_paid", rtax_paid.ToString());
            Update = Update.Replace("?rtaxid", rtaxid.ToString());

            result = ExecuteCommand(Update);
            return Classes.CConstant.GetResult(result);
        }

        public object DeleteRoadTax(int rtaxid)
        {
            string Delete = DELCMD.Replace("?rtaxid", rtaxid.ToString());

            return ExecuteCommand(Delete);
        }
    }
}
