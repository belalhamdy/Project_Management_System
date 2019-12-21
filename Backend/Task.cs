using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Planner
{
    class Task
    {
        private Task parentTask;

        public List<Task> DependantTasks { get; set; }
        private List<Task> _SubTasks;
        public List<Employee> AssignedEmployees { get; set; }

        public string Title { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime DueDate { get; set; }
        public int WorkingHours { get; set; }
        public int ActualWorkingHours { get; set; }
        public bool IsMilestone { get; set; }
        public bool IsCompleted { get; set; }


        public ReadOnlyCollection<Task> SubTasks
        {
            get {
                return _SubTasks.AsReadOnly();
            }
        }
        public void AddSubtask(Task task)
        {
            if (task.StartingDate < this.StartingDate || task.DueDate > this.DueDate)
                throw new TaskException("Subtask's working window does not fit in its parent.");
            else
            {
                if (task.parentTask != null)
                    throw new TaskException("Task is already a subtask of another task.");
                _SubTasks.Add(task);
                task.parentTask = this;
            }
        }
        public void RemoveSubtask(Task task)
        {
            try
            {
                _SubTasks.Remove(task);
                task.parentTask = null;
            }
            catch(Exception)
            {
                throw new TaskException("Given task is not a subtask of this task.");
            }
        }
    }
}
