using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_OOP_project.Classes
{
    public class Items
    { 
        public int ItemID { get; set; }
        public string LegoTheme { get; set; }
        public string AgeRange { get; set;}
        public string getlegoTheme()
        {
            return LegoTheme;
        }
        public string getAgeRange()
        {
            return AgeRange;
        }

    }

}
