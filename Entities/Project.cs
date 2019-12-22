using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Entities
{
    public class Project
    {
        public Project(int id, string projectName, DateTime startingDate, DateTime dueDate, int hrsPerDay, int startingOfWeek)
        {
            ProjectName = projectName;
            StartingDate = startingDate;
            DueDate = dueDate;
            NumberHrsPerDay = hrsPerDay;
            StartingOfWeek = startingOfWeek;

            ID = id;
        }
        public Project(string projectName, DateTime startingDate, DateTime dueDate, int hrsPerDay, int startingOfWeek)
            : this(-1, projectName, startingDate, dueDate, hrsPerDay, startingOfWeek) { }

        public int ID { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Cost { get; set; }
        public int NumberHrsPerDay { get; set; }
        public int StartingOfWeek { get; set; }

    }
}
