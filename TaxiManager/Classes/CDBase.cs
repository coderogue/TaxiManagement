using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TaxiManager.Classes
{
    class CDBase
    {
        private string ConnString = "Server=localhost;Database=taxi_management;Uid=root;Pwd=mysql";
        private MySqlConnection Conn = null;

        public CDBase() { }

        //To retrieve SELECT Command data to DataTable
        protected DataTable GetDTable(string SQL)
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
                MessageBox.Show(ex.Message, Classes.Messages.TTLDefault);
                Conn.Close();
                DT = null;
            }
            finally
            {
                Conn.Close();
            }
            return DT;
        }

        //To retrieve SCALAR Command
        protected object GetSCALAR(string SQL)
        {
            object result = null;
            try
            {
                Conn = new MySqlConnection(ConnString);
                Conn.Open();
                MySqlCommand CMD = new MySqlCommand(SQL, Conn);
                result = CMD.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, Classes.Messages.TTLDefault);
                Conn.Close();
            }
            finally
            {
                Conn.Close();
            }

            return result;
        }

        //To execute INSERT, UPDATE, DELETE Command
        //public int ExecuteCommand(string SQL)
        //{
        //    int result = 0;
        //    try
        //    {
        //        Conn = new MySqlConnection(ConnString);
        //        Conn.Open();
        //        MySqlCommand CMD = new MySqlCommand(SQL, Conn);
        //        result = CMD.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        MessageBox.Show(ex.Message, Classes.Messages.TTLDefault);
        //        //result = ex.Message + "\n" + ex.StackTrace;
        //        Conn.Close();
        //    }
        //    finally
        //    {
        //        Conn.Close();
        //    }
        //    return result;
        //}

        protected object ExecuteCommand(string SQL)
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
