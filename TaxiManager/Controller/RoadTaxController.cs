using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TaxiManager.Controller
{
    class RoadTaxController : Model.RoadTaxModel
    {
        public DataTable GetRoadTax(int taxiid, string Clauses)
        {
            if (!string.IsNullOrEmpty(Clauses))
                if (!Clauses.ToUpper().StartsWith("AND"))
                    Clauses = "And " + Clauses;
            return RoadTaxList(taxiid, Clauses);
        }

        public DataTable GetPaidRoadTax(int taxiid)
        {
            return RoadTaxList(taxiid, "AND rtax_paid = TRUE");
        }

        public DateTime GetNextPayment(int taxiid)
        {
            DateTime NewDate = DateTime.Today;
            int months = 0;
            DataTable DT = GetPaidRoadTax(taxiid);
            if (DT.Rows.Count > 0)
            {
                months = Convert.ToInt32(DT.Rows[0]["rtax_dtype"]);
                NewDate = Convert.ToDateTime(DT.Rows[0]["rtax_date"]).AddMonths(6 * months);
            }

            return NewDate;
        }
    }
}
