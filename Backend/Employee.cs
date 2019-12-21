using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Planner
{
    enum Title { ProjectManger, TeamMember} //TODO Add diffrent Title 
    class Employee //Employee Class
    {
        public Title Title { get; set; }
        public int HoursDay { get; set; } //Hours per day
    }
}
