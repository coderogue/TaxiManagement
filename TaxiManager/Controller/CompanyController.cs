using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TaxiManager.Controller
{
    class CompanyController : Model.CompanyModel
    {
        public DataTable GetCompanies(string Clauses)
        {
            if (!string.IsNullOrEmpty(Clauses))
                Clauses = "AND (com_name LIKE '%" + Clauses + "%' OR com_no LIKE '%" + Clauses + "%')";
            return GetCompanyList(Clauses);
        }

        public DataTable GetCompany(int comid)
        {
            string Clause = "";
            if (comid != 0)
                Clause = "AND comid = " + comid;

            return GetCompanyList(Clause);
        }
    }
}
