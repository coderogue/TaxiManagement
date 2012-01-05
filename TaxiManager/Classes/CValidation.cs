using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxiManager.Classes
{
    class CValidation
    {
        //private static string IntValidation = "r\"[+-]?((\\d+(\\.\\d*)?)|\\.\\d+)([eE][+-]?[0-9]+)?\"";
        //private static string CurrValidation = "";
        //private static string DateValidation = "";
        //private static string TimeValidation = "";
        //private static string EmailValidation = "";

        public bool ValidateDouble(string figure)
        {
            double _figure = 0;
            return double.TryParse(figure, out _figure);
        }

        public bool ValidateInteger(string figure)
        {
            int _figure = 0;
            return int.TryParse(figure, out _figure);
        }

        public bool ValidateDate(string figure)
        {
            DateTime _figure = DateTime.Today;
            return DateTime.TryParse(figure, out _figure);
        }
    }
}
