using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TaxiManager.Controller
{
    class ColourController : Model.ColourModel
    {
        public DataTable GetColourTable(string Clauses)
        {
            if(!string.IsNullOrEmpty(Clauses))
                Clauses = "AND colour_desc LIKE '%" + Clauses + "%'";
            return GetColours(Clauses);
        }
    }
}
