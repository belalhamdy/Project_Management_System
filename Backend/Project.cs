using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Planner
{
    class Project
    {
        private string ProjectName { get; set; }
        private Employee ProjectManager { get; set; }
        private List<Employee> TeamMembers { get; set; }
        private DateTime StartingDate { get; set; }
        private DateTime DueDate { get; set; }
        private double Cost { get; set; }
        private int NumberHrsPerDay { get; set; }
        private int StartingOfWeek { get; set; }

    }
}
