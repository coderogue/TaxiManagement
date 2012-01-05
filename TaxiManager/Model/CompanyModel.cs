using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace TaxiManager.Model
{
    class CompanyModel : Classes.CDBase
    {
        private const string SELCMD = "SELECT * FROM companies WHERE rec_status = TRUE ";
        private const string INSCMD = "INSERT INTO companies (com_name, com_no, com_date, com_address, com_tel, com_fax, com_id, c_by, c_date, u_by, u_date, rec_status) " +
                                      "VALUES ('?com_name', '?com_no', '?com_date', '?com_address', '?com_tel', '?com_fax', '?com_id', ?c_by, NOW(), ?c_by, NOW(), TRUE)";
        private const string UPDCMD = "UPDATE companies SET " +
                                      "com_name = '?com_name', " +
                                      "com_no = '?com_no', " +
                                      "com_date = '?com_date', " +
                                      "com_address = '?com_address', " +
                                      "com_tel = '?com_tel', " + 
                                      "com_fax = '?com_fax', " + 
                                      "com_id = '?com_id', " +
                                      "u_by = ?u_by, " +
                                      "u_date = NOW() " +
                                      "WHERE comid = ?comid";
        private const string DELCMD = "UPDATE COMPANIES SET rec_status = FALSE WHERE comid = ?comid";

        protected DataTable GetCompanyList(string Clauses)
        {
            return GetDTable(SELCMD + Clauses);
        }

        public int InsertCompany(string com_name, string com_no, DateTime com_date, string com_address, string com_tel, string com_fax, string com_id, int c_by)
        {
            string Insert = INSCMD;
            object result = 0;
            Insert = Insert.Replace("?com_name", com_name);
            Insert = Insert.Replace("?com_no", com_no);
            Insert = Insert.Replace("?com_date", com_date.ToString("yyyy-MM-dd"));
            Insert = Insert.Replace("?com_address", com_address);
            Insert = Insert.Replace("?com_tel", com_tel);
            Insert = Insert.Replace("?com_fax", com_fax);
            Insert = Insert.Replace("?com_id", com_id);
            Insert = Insert.Replace("?c_by", c_by.ToString());

            result = ExecuteCommand(Insert);
            if (result is int)
                return (int)result;
            else
                if (result.ToString().StartsWith("Duplicate"))
                {
                    RecoverCompany(com_no, c_by);
                    DataTable D = GetCompanyList("AND com_no = '" + com_no + "' AND com_name = '" + com_name + "'");
                    if (D.Rows.Count > 0)
                    {
                        int RowID = Convert.ToInt32(D.Rows[0]["comid"]);
                        UpdateCompany(com_name, com_no, com_date, com_address, com_tel, com_fax, com_id, c_by, RowID); ;
                    }
                }
                else
                    MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        public int UpdateCompany(string com_name, string com_no, DateTime com_date, string com_address, string com_tel, string com_fax, string com_id, int u_by, int comid)
        {
            string Update = UPDCMD;
            object result = 0;
            Update = Update.Replace("?com_name", com_name);
            Update = Update.Replace("?com_no", com_no);
            Update = Update.Replace("?com_date", com_date.ToString("yyyy-MM-dd"));
            Update = Update.Replace("?com_address", com_address);
            Update = Update.Replace("?com_tel", com_tel);
            Update = Update.Replace("?com_fax", com_fax);
            Update = Update.Replace("?com_id", com_id);
            Update = Update.Replace("?u_by", u_by.ToString());
            Update = Update.Replace("?comid", comid.ToString());

            result = ExecuteCommand(Update);
            if (result is int)
                return (int)result;
            else
                MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        public int DeleteCompany(int comid)
        {
            string Delete = DELCMD;
            object result = 0;
            Delete = Delete.Replace("?comid", comid.ToString());

            result = ExecuteCommand(Delete);
            if (result is int)
                return (int)result;
            else
                MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        private void RecoverCompany(string com_no, int u_by)
        {
            string UpdateQuery = "UPDATE companies SET rec_status = TRUE, u_by = " + u_by + ", u_date = NOW() WHERE com_no = '" + com_no + "'";
            ExecuteCommand(UpdateQuery);
        }
    }
}
