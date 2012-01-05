using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaxiManager.Classes
{
    static class CConstant
    {
        public const int LISTVIEW = 1;
        public const int FORMVIEW = 2;

        public static int LoginID = 1;

        public static int GetResult(object result)
        {
            if (result is int)
                return (int)result;
            else
            {
                MessageBox.Show(result.ToString(), Messages.TTLDefault);
                return 0;
            }
        }
    }
}
