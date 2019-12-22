using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Project_Management_System.Entities
{
    public class Task
    {
        public enum TypeOfTask
        {
            Task = 0, SubTask, Milestone = 2
        }

        public Task(int id, int? parentTask, int taskType, int projectId, DateTime startingDate, DateTime dueDate, string title, int? actualWorkingHours, bool isFinished)
        {
            ID = id;
            this.parentTask = parentTask;
            TaskType = (TypeOfTask)taskType;
            ProjectID = projectId;
            StartingDate = startingDate;
            DueDate = dueDate;
            Title = title;
            ActualWorkingHours = actualWorkingHours;
            IsFinished = isFinished;
        }
        public Task( int? parentTask, int taskType, int projectId, DateTime startingDate, DateTime dueDate, string title, int? actualWorkingHours, bool isFinished)
            : this( -1,  parentTask,  taskType,  projectId,  startingDate,  dueDate, title, actualWorkingHours, isFinished) { }

        public int ID { get; set; }
        private int? parentTask;
        public TypeOfTask TaskType { get; set; }

        public int ProjectID { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Title { get; set; }
        public int? ActualWorkingHours { get; set; }
        public bool IsFinished { get; set; }

        private List<Task> _SubTasks = new List<Task>();
        public List<Employee> AssignedEmployees { get; set; }

        public int WorkingHours { get; set; }

        public bool IsMilestone
        {
            get {
                return TaskType == TypeOfTask.Milestone;
            }
            set {
                if (value == true) TaskType = TypeOfTask.Milestone;
                else TaskType = TypeOfTask.Task;
            }
        }

        public ReadOnlyCollection<Task> SubTasks
        {
            get
            {
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
                task.parentTask = this.ID;
            }
        }
        public void RemoveSubtask(Task task)
        {
            try
            {
                _SubTasks.Remove(task);
                task.parentTask = null;
            }
            catch (Exception)
            {
                throw new TaskException("Given task is not a subtask of this task.");
            }
        }
        public void ClearSubtasks()
        {
            _SubTasks.Clear();
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
