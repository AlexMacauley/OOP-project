using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_OOP_project.Classes
{
    public class Stock
    {
        public int StockID { get; set; }
        public int quantityofitems { get; set; }


        public int getquantityofitems()
        {
            return quantityofitems;
        }

    }
}
