using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace TaxiManager.Controller
{
    class BodyTypeController : Model.BodyTypeModel
    {

        public DataTable GetTypes(string Clauses)
        {
            if (!string.IsNullOrEmpty(Clauses))
                Clauses = "WHERE bt_desc LIKE '%" + Clauses + "%'";

            return GetBodyTypes(Clauses);
        }
    }
}
