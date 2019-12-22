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
            this.ParentTask = parentTask;
            TaskType = (TypeOfTask)taskType;
            ProjectID = projectId;
            StartingDate = startingDate;
            DueDate = dueDate;
            Title = title;
            ActualWorkingHours = actualWorkingHours;
            IsFinished = isFinished;
            SubTasks = new List<Task>();
        }
        public Task( int? parentTask, int taskType, int projectId, DateTime startingDate, DateTime dueDate, string title, int? actualWorkingHours, bool isFinished)
            : this( -1,  parentTask,  taskType,  projectId,  startingDate,  dueDate, title, actualWorkingHours, isFinished) { }

        public int ID { get; set; }
        public int? ParentTask { get; set; }
        public TypeOfTask TaskType { get; set; }

        public int ProjectID { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Title { get; set; }
        public int WorkingHours {
            get {
                return (DueDate - StartingDate).Days * 8;
            }
        }
        public int? ActualWorkingHours { get; set; }
        public bool IsFinished { get; set; }

        public List<Employee> AssignedEmployees { get; set; }

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

        public List<Task> SubTasks { get; }

        public override string ToString()
        {
            return Title;
        }
    }
}
