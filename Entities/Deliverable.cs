using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Entities
{
    public class Deliverable
    {
        public Deliverable(int id, int projectId, bool isFinished, string title, string description)
        {
            ID = id;
            ProjectID = projectId;
            IsFinished = isFinished;
            Title = title;
            Description = description;
        }
        public Deliverable(int projectId, bool isFinished, string title, string description)
            :this(-1, projectId, isFinished, title, description) { }



        public int ID { get; set; }
        public int ProjectID { get; set; }
        public bool IsFinished { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
