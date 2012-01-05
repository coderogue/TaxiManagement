using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TaxiManager.Controller
{
    class FuelController : Model.FuelModel
    {
        public DataTable GetFuelTypes(string Clauses)
        {
            if (!string.IsNullOrEmpty(Clauses))
                Clauses = "AND ft_desc LIKE '%" + Clauses + "%'";

            return GetFuelTable(Clauses);
        }
    }
}
