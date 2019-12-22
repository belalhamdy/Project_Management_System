using Project_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = Project_Management_System.Entities.Task;

namespace Project_Management_System.GUI
{
    public partial class frmPlanning : Form
    {
        enum EntryMode
        {
            Add, Edit
        }
        private EntryMode currentMode;
        private Project OwnerProject;
        public frmPlanning(Project project)
        {
            this.OwnerProject = project;
            InitializeComponent();
        }

        private void MainTaskForm_Load(object sender, EventArgs e)
        {
            ReloadTasksList();
        }
        
        private void SetEntryToAdd()
        {
            txtTitle.Clear();
            dtpStartDate.Value = dtpDueDate.Value = DateTime.Now;
            numWorkingHours.Value = numWorkingHours.Minimum;
            numActualWorkingHours.Value = numWorkingHours.Minimum;
            btnAddEdit.Text = "Add New Task";
            ReloadFreeEmployeesList();
            lstSelectedEmployees.Items.Clear();
            currentMode = EntryMode.Add;
        }
        private void SetEntryToEdit(Task tag)
        {
            txtTitle.Text = tag.Title;
            dtpStartDate.Value = tag.StartingDate;
            dtpDueDate.Value = tag.DueDate;
            numWorkingHours.Value = tag.WorkingHours;
            numActualWorkingHours.Value = tag.ActualWorkingHours ?? 0;
            btnAddEdit.Text = "Edit Selected Task";
            ReloadFreeEmployeesList();
            LoadEmployeeListIntoListView(lstSelectedEmployees, tag.AssignedEmployees);
            currentMode = EntryMode.Edit;
        }


        private void btnUnselect_Click(object sender, EventArgs e)
        {
            trvTasks.SelectedNode = null;
        }


        #region Reloading Lists

        private void ReloadTasksList()
        {
            List<Task> retrieved = Program.dbms.GetAllMainTasks(OwnerProject.ID);
            var highNode = new TreeNode(OwnerProject.ProjectName);
            highNode.Tag = null;
            foreach (var tsk in retrieved)
            {
                LoadEmployeesAndSubtasksForTask(tsk);

                var node = new TreeNode(tsk.ToString());
                node.Tag = tsk;

                GenerateSubNodesFromTask(node);

                highNode.Nodes.Add(node);
            }
            trvTasks.Nodes.Clear();
            trvTasks.Nodes.Add(highNode);
            trvTasks.SelectedNode = null;
        }
        private void LoadEmployeesAndSubtasksForTask(Task tsk)
        {
            tsk.AssignedEmployees = Program.dbms.GetEmployeesOnTask(tsk.ID);
            List<Task> subtasks = Program.dbms.GetAllSubTasks(tsk.ID);
            tsk.ClearSubtasks();
            foreach (var subtsk in subtasks)
            {
                LoadEmployeesAndSubtasksForTask(subtsk);
                tsk.AddSubtask(subtsk);
            }
        }
        private void GenerateSubNodesFromTask(TreeNode node)
        {
            node.Nodes.Clear();
            foreach (var subtask in ((Task)node.Tag).SubTasks)
            {
                TreeNode subNode = new TreeNode(subtask.ToString());
                subNode.Tag = subtask;
                GenerateSubNodesFromTask(subNode);
                node.Nodes.Add(subNode);
            }
        }
        private void ReloadFreeEmployeesList()
        {
            List<Employee> ret = Program.dbms.GetAllFreeEmployees();
            LoadEmployeeListIntoListView(lstEmployees, ret);
        }
        public static void LoadEmployeeListIntoListView(ListView lv, List<Employee> lst)
        {
            lv.Items.Clear();
            foreach(var emp in lst)
            {
                var lvi = new ListViewItem(emp.ID.ToString());
                lvi.SubItems.Add(emp.Name);
                lv.Items.Add(lvi);
            }
        }
        #endregion

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSelectEmployee.Enabled = lstEmployees.SelectedIndices.Count != 0;
        }

        private void lstSelectedEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUnselectEmployee.Enabled = lstSelectedEmployees.SelectedIndices.Count != 0;
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if (trvTasks.SelectedNode == null) return;
            txtTitle.Text = txtTitle.Text.Trim();
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Title of task cannot be empty!", "Invalid Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpStartDate.Value >= dtpDueDate.Value)
            {
                MessageBox.Show("Due Date of Project must be later than the start date", "Invalid Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpStartDate.Value >= OwnerProject.DueDate || dtpDueDate.Value <= OwnerProject.StartingDate)
            {
                MessageBox.Show("Task schedule does not fit in the project's schedule.", "Invalid Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TreeNode parent = null;
            if (currentMode == EntryMode.Add)
                parent = trvTasks.SelectedNode;
            else if (currentMode == EntryMode.Edit)
                parent = trvTasks.SelectedNode.Parent;

            if (parent.Tag != null)
            {
                Task p = (Task)parent.Tag;
                if (dtpStartDate.Value >= p.DueDate || dtpDueDate.Value <= p.StartingDate)
                {
                    MessageBox.Show("Task does not fit in its parent's schedule.", "Invalid Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (currentMode == EntryMode.Add)
            {
                int? id = null;
                if (parent.Tag != null) id = ((Task)parent.Tag).ID;
                bool isFinished = false; //TODO: involve finished
                int taskType = (int)Task.TypeOfTask.Task;
                int? actualWork = numActualWorkingHours.Value == 0 ? null : (int?)numActualWorkingHours.Value;
                Task addedTask = new Task(id, taskType, OwnerProject.ID, dtpStartDate.Value, dtpDueDate.Value, txtTitle.Text, actualWork, isFinished);
                Program.dbms.AddTask(addedTask);
            }
            else if (currentMode == EntryMode.Edit)
                parent = trvTasks.SelectedNode.Parent;
        }
    }
}
