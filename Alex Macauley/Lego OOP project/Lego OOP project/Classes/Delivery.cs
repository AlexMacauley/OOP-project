using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_OOP_project.Classes
{
    public class Delivery
    {
        public int DeliveryID { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryContactNumber { get; set; }
        public string WeightofDelivery {get; set;}
        public Delivery()
        {

        }

        public string getdeliveryaddress()
        {
            return DeliveryAddress;
        }
        public string getdeliverycontactnumber()
        {
            return DeliveryContactNumber;
        }
        public string getweightofdevlivery()
        {
            return WeightofDelivery;
        }

    }
}
