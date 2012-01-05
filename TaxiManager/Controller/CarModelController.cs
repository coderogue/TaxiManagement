using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace TaxiManager.Controller
{
    class CarModelController : Model.CarModelModel
    {

        public DataTable GetModels(string Clauses)
        {
            if (!String.IsNullOrEmpty(Clauses))
                Clauses = "AND mm_name LIKE '%" + Clauses + "%'";

            return GetCarModels(Clauses);
        }

        
    }
}
