using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_OOP_project.Classes
{
    public class Employees
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public Employees()
        {

        }
        public Employees(string emp, string loc, int empa, int pho, string ranking)
        {
            emp = EmployeeName;
            loc = Location;
            empa = Age;
            pho = PhoneNumber;

        }
        public string getemployeename()
        {
            return EmployeeName;
        }
        public int getpage()
        {
            return Age;
        }
        public int getphonenumber()
        {
            return PhoneNumber;

        }
        public int getId()
        {
            return Id;
        }
    }
}
