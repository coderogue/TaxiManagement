using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TaxiManager.Controller
{
    class VehicleCategoryController : Model.VehicleCategoryModel
    {
        public DataTable GetCategories(string Clauses)
        {
            if (!string.IsNullOrEmpty(Clauses))
                Clauses = "AND vcat_desc LIKE '%" + Clauses + "%'";

            return GetCats(Clauses);
        }
    }
}
