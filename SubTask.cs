using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Planner
{
    class SubTask :Task
    {
        private DateTime MTaskStartingDate; //Main Task Starting Date To limit Starting Date of theSub Task
        private DateTime MTAskDueDate;  //Main Task Due Date To limit Due Date of the Sub Task
    }
}
