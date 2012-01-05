using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TaxiManager.Controller
{
    class ClassTypeController: Model.ClassTypeModel
    {
        public DataTable GetClassTypes(string Clauses)
        {
            if (!string.IsNullOrEmpty(Clauses))
                Clauses = "AND ct_desc LIKE '%" + Clauses + "%'";
            return GetClassList(Clauses);
        }

    }
}
