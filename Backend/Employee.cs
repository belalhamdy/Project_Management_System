using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Planner
{
    enum Title { ProjectManger, TeamMember} //TODO Add different Titles
    class Employee //Employee Class
    {
        public String Name { get; set; }
        public Title Title { get; set; }
        public int HoursDay { get; set; } //Hours per day
    }
}
