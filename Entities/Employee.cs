using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Entities
{
    public class Employee
    {
        public Employee(string name, string title, int hours, int cost)
        {
            Name = name;
            Title = title;
            HoursDay = hours;
            Cost = cost;

            ID = -1;
        }
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int HoursDay { get; set; }
        public int Cost { get; set; }
    }
}
