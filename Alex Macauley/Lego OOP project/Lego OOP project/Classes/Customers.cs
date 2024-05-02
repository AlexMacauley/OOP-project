using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lego_OOP_project.Classes
{
    public class Customers
    {
        public int CusID { get; set; }
        public string Telephonenumber { get; set; }
        public string Paymenttype { get; set; }
        public int Cusage { get; set; }
        public string Cusname { get; set; }

        public int getCusId()
        {
            return CusID;
        }
        public string gettelephonenumber()
        {
            return Telephonenumber;
        }
        public string getpaymentype()
        {
            return Paymenttype;
        }
        public string getcusname()
        {
            return Cusname;
        }
        public int getage()
        {
            return Cusage;
        }
    }
}
