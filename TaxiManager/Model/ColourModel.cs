using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace TaxiManager.Model
{
    class ColourModel : Classes.CDBase
    {

        protected const string SELCMD = "SELECT * FROM colours WHERE rec_status = TRUE ";
        protected const string INSCMD = "INSERT INTO colours (colour_desc, c_by, c_date, u_by, u_date, rec_status) " +
                                        "VALUES ('?colour_desc', ?c_by, NOW(), ?c_by, NOW(), TRUE)";
        protected const string UPDCMD = "UPDATE colours SET colour_desc = '?colour_desc', u_by = ?u_by, u_date = NOW() " + 
                                        "WHERE colourid = ?colourid";
        protected const string DELCMD = "UPDATE colours SET rec_status = FALSE WHERE colourid = ?colourid";

        public DataTable GetColours(string Clauses)
        {
            return GetDTable(SELCMD + Clauses);
        }

        public int InsertColour(string colour_desc, int c_by)
        {
            string Insert = INSCMD;
            object result = 0;
            Insert = Insert.Replace("?colour_desc", colour_desc);
            Insert = Insert.Replace("?c_by", c_by.ToString());

            result = ExecuteCommand(Insert);
            if (result is int)
                return (int)result;
            else
                if (result.ToString().StartsWith("Duplicate"))
                    RecoverColour(colour_desc, c_by);
                else
                    MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        public int UpdateColour(string colour_desc, int u_by, int colourid)
        {
            string Update = UPDCMD;
            object result = 0;
            Update = Update.Replace("?colour_desc", colour_desc);
            Update = Update.Replace("?u_by", u_by.ToString());
            Update = Update.Replace("?colourid", colourid.ToString());

            result = ExecuteCommand(Update);
            if (result is int)
                return (int)result;
            else
                MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        public int DeleteColour(int colourid)
        {
            string Delete = DELCMD;
            object result = 0;
            Delete = Delete.Replace("?colourid", colourid.ToString());

            result = ExecuteCommand(Delete);
            if (result is int)
                return (int)result;
            else
                MessageBox.Show(result.ToString(), Classes.Messages.TTLDefault);
            return 0;
        }

        private void RecoverColour(string colour_desc, int u_by)
        {
            string UpdateQuery = "UPDATE colours SET rec_status = TRUE, u_by = " + u_by + ", u_date = NOW() WHERE colour_desc = '" + colour_desc + "'";
            ExecuteCommand(UpdateQuery);
        }
    }
}
