using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TaxiManager.Controller
{
    class OwnerStatusController : Model.OwnerStatusModel
    {
        public DataTable GetOwnerStatuses(string Clauses)
        {
            if (!string.IsNullOrEmpty(Clauses))
                Clauses = "AND os_desc LIKE '%" + Clauses + "%'";
            return GetOwerStatusList(Clauses);
        }
    }
}
