using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Planner
{
    class MainTask : Task //General Tasks Class
    {
        private List<Task> DependantTasks;
        private List<SubTask> SubTasks;
        private List<Employee> AssignedEmployees;
    }
}
