using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;

namespace TaxiManagerTester
{
    [TestClass]
    public class ExecuteCommandTextCase
    {
        private string ConnString = "Server=localhost;Database=taxi_management;Uid=root;Pwd=mysql";
        private MySqlConnection Conn = null;

        [TestMethod]
        public object ExecuteCommand(string SQL)
        {
            object result = 0;
            try
            {
                Conn = new MySqlConnection(ConnString);
                Conn.Open();
                MySqlCommand CMD = new MySqlCommand(SQL, Conn);
                result = CMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //MessageBox.Show(ex.Message, Classes.Messages.TTLDefault);
                result = ex.Message + "\n" + ex.StackTrace;
                Conn.Close();
            }
            finally
            {
                Conn.Close();
            }
            return result;
        }
    }
}
