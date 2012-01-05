using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TaxiManager.Controller
{
    class TaxiController : Model.TaxiModel
    {

        public DataTable GetTaxi(string Clauses)
        {
            if (!string.IsNullOrEmpty(Clauses))
                Clauses = "AND taxi_regno LIKE '%" + Clauses + "%'";

            return GetTaxiList(Clauses);
        }

        public DataTable GetTaxi(int TaxiID)
        {
            string Clauses = "";
            if (TaxiID != 0)
                Clauses = "AND taxiid = " + TaxiID;

            return GetTaxiList(Clauses);
        }
    }
}
