using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TaxiManager.Controller
{
    class USSideBannerController : Model.RoadTaxModel
    {
        //private Model.RoadTaxModel rtModel = new Model.RoadTaxModel();

        public DataTable GetRoadTax()
        {
            return RoadTaxList(2, "AND rtax_paid = TRUE");  
        }
    }
}
