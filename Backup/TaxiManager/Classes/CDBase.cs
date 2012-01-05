using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace TaxiManager.Classes
{
    class CDBase
    {
        private string ConnString = "Server=localhost;Database=taxi_management;Uid=root;Pwd=mysql";
        private MySqlConnection Conn = null;

        public CDBase() { }

        //To retrieve SELECT Command data to DataTable
        public DataTable GetDTable(string SQL)
        {
            DataTable DT = new DataTable(); ;
            try
            {
                Conn = new MySqlConnection();
                Conn.ConnectionString = ConnString;
                Conn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(SQL, Conn);
                DA.Fill(DT);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Conn.Close();
                DT = null;
            }
            finally
            {
                Conn.Close();
            }
            return DT;
        }

        //To execute INSERT, UPDATE, DELETE Command
        public int ExecuteCommand(string SQL)
        {
            int result = 0;
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
