using Lego_OOP_project.Classes;
using System.Collections.Generic;

string[] menu = { "View products", "View Delivery", "View employees", "Customer Purchases", "Items List" };


List<Employees> employees = new List<Employees>
        {
            new Employees
            {
                Id = 1, 
                EmployeeName = "John Smith",
                Age = 18,
                Location = "Carlisle",
                PhoneNumber = 123
            },
            new Employees
            {
                Id = 2,
                EmployeeName = "Jane Doe",
                Age = 25,
                Location = "Carlisle",
                PhoneNumber = 456
            },
            new Employees
            {
                Id = 3,
                EmployeeName = "Michael Johnson",
                Age = 30,
                Location = "Carlisle",
                PhoneNumber = 789
            }
        };
 List<Delivery> deliveries = new List<Delivery>
        {
            new Delivery
            {
                DeliveryID = 1,
                DeliveryAddress = "CA2 OP3",
                DeliveryContactNumber = "1275 4524 3333",
                WeightofDelivery = "4KG"
            },
            new Delivery
            {
                DeliveryID = 2,
                DeliveryAddress = "CA1 LL4",
                DeliveryContactNumber = "212 555 1212",
                WeightofDelivery = "2.5KG"
            },
            new Delivery
            {
                DeliveryID = 3,
                DeliveryAddress = "CA5 HJ6",
                DeliveryContactNumber = "20 7123 4567",
                WeightofDelivery = "6KG"
            }
        };
 List<Items> Items = new List<Items>
{
    new Items
    {
        ItemID = 1,
        LegoTheme = "Star Wars",
        AgeRange = "12 to 15"

    },
    new Items
    {
        ItemID = 2,
        LegoTheme = "Ninjago",
        AgeRange = "8 to 10"

    },
    new Items
    {
        ItemID = 3,
        LegoTheme = "Flowers",
        AgeRange = "12 to 16"

    }

};
List<Customers> Customers = new List<Customers>
{
   
new Customers
{
    CusID = 1,
    Telephonenumber = "8586 3453 4544",
    Paymenttype = "ApplePay",
    Cusage = 18,
    Cusname = "John"
},
new Customers
{
    CusID = 2,
    Telephonenumber = "8586 3453 5353",
    Paymenttype = "PayPal",
    Cusage = 55,
    Cusname = "Jasper"
},
new Customers
{
    CusID = 3,
    Telephonenumber = "8586 3453 8382",
    Paymenttype = "Credit Card",
    Cusage = 23,
    Cusname = "Aiden"
}
};






//Console.WriteLine(menu[0]);
int counter = 0;
int userinput = 0;


while (true)
{
    foreach (var item in menu)
    {
        Console.WriteLine("{0} {1}", counter, item);
        counter++;
    }
    userinput = int.Parse(Console.ReadLine());
    switch (userinput)
    {
        case 0:
            Console.WriteLine("this is the products list");
            break;
        case 1:
            Console.Clear();
            foreach (var item in deliveries)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.DeliveryID, item.DeliveryAddress, item.DeliveryContactNumber, item.WeightofDelivery);
            }

            break;
        case 2:
            Console.Clear();
            foreach(var item in employees)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", item.Id, item.EmployeeName, item.Age, item.PhoneNumber, item.Location);
            }
            break;
        case 3:
            Console.Clear();
            foreach (var item in Customers)
            Console.WriteLine("{0} {1} {2} {3} {4}", item.CusID, item.Cusname, item.Cusage,item.Telephonenumber, item.Paymenttype);
            break;
            case 4:
            Console.Clear();
            foreach (var item in Items)
            {
                Console.WriteLine("{0} {1} {2}", item.ItemID,item.LegoTheme,item.AgeRange);
            }
            break;
            case 5:
            Console.Clear();
            foreach (var item in )

    };
    Console.ReadLine();
    Console.Clear();
    counter = 0;
}
