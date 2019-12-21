using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Planner
{
    class Task //Abstract Task Class
    {
        private String Title;
        private DateTime StartingDate;
        private DateTime DueDate;
        private int WorkingHours;
        private int ActualWorkingHours;
        private bool Milestone;
        private bool Completed;
    }
}
