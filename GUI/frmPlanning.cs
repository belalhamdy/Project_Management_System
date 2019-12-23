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
        private Project ownerProject;
        public frmPlanning(Project project)
        {
            this.ownerProject = project;
            InitializeComponent();
        }

        private void MainTaskForm_Load(object sender, EventArgs e)
        {
            ReloadTasksList();
            
        }
        
        private void SetEntryToAdd()
        {
            txtTitle.Clear();
            chkIsFinished.Checked = false;
            chkIsMilestone.Checked = false;
            dtpStartDate.Value = dtpDueDate.Value = DateTime.Now;
            numActualWorkingHours.Value = numWorkingHours.Minimum;
            btnAddEdit.Text = "Add New Task";
            ReloadFreeEmployeesList();
            lstSelectedEmployees.Items.Clear();
            currentMode = EntryMode.Add;
        }
        private void SetEntryToEdit(Task tag)
        {
            txtTitle.Text = tag.Title;
            chkIsFinished.Checked = tag.IsFinished;
            chkIsMilestone.Checked = tag.IsMilestone;
            dtpStartDate.Value = tag.StartingDate;
            dtpDueDate.Value = tag.DueDate;
            numActualWorkingHours.Value = tag.ActualWorkingHours ?? 0;
            btnAddEdit.Text = "Edit Selected Task";
            ReloadFreeEmployeesList();
            LoadEmployeeListIntoListView(lstSelectedEmployees, tag.AssignedEmployees);
            currentMode = EntryMode.Edit;
        }


        private void btnUnselect_Click(object sender, EventArgs e)
        {
            SetEntryToAdd();
        }


        #region Reloading Lists

        private void ReloadTasksList()
        {
            List<Task> retrieved = Program.dbms.GetAllMainTasks(ownerProject.ID);
            var highNode = new TreeNode(ownerProject.ProjectName);
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
            trvTasks.SelectedNode = trvTasks.Nodes[0];
            trvTasks.ExpandAll();
            trvTasks.Nodes[0].EnsureVisible();
            ReloadFreeEmployeesList();
            SetEntryToAdd();
        }
        private void LoadEmployeesAndSubtasksForTask(Task tsk)
        {
            tsk.AssignedEmployees = Program.dbms.GetEmployeesOnTask(tsk.ID);
            List<Task> subtasks = Program.dbms.GetAllSubTasks(tsk.ID);
            tsk.SubTasks.Clear();
            foreach (var subtsk in subtasks)
            {
                LoadEmployeesAndSubtasksForTask(subtsk);
                tsk.SubTasks.Add(subtsk);
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
                lvi.SubItems.Add(emp.HoursDay.ToString());
                lvi.SubItems.Add(emp.Cost.ToString());
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
            if (chkIsMilestone.Checked) dtpDueDate.Value = dtpStartDate.Value;
            if (trvTasks.SelectedNode == null)
            {
                MessageBox.Show("Nothing is selected!", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtTitle.Text = txtTitle.Text.Trim();
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Title of task cannot be empty!", "Invalid Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpStartDate.Value > dtpDueDate.Value)
            {
                MessageBox.Show("Due Date of Project must be later than the start date", "Invalid Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpStartDate.Value < ownerProject.StartingDate || dtpDueDate.Value > ownerProject.DueDate)
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
                bool isFinished = chkIsFinished.Checked;
                int taskType = (int)(chkIsMilestone.Checked ? Task.TypeOfTask.Milestone : Task.TypeOfTask.Task);
                int? actualWork = numActualWorkingHours.Value == 0 ? null : (int?)numActualWorkingHours.Value;
                Task addedTask = new Task(id, taskType, ownerProject.ID, dtpStartDate.Value, dtpDueDate.Value, txtTitle.Text, actualWork, isFinished);

                try
                {
                    int taskID = Program.dbms.AddTask(addedTask);
                    List<int> lst = GetSelectedEmployees();
                    if (lst == null) return;
                    Program.dbms.SetEmployeesOnTask(taskID, lst);
                    ReloadTasksList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unable to add to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else if (currentMode == EntryMode.Edit)
            {
                try
                {
                    Task cur = ((Task)trvTasks.SelectedNode.Tag);
                    int taskID = cur.ID;
                    cur.DueDate = dtpDueDate.Value;
                    cur.StartingDate = dtpStartDate.Value;
                    cur.Title = txtTitle.Text;
                    cur.ActualWorkingHours = numActualWorkingHours.Value == 0 ? null : (int?)numActualWorkingHours.Value;
                    cur.IsFinished = chkIsFinished.Checked;
                    cur.TaskType = (chkIsMilestone.Checked ? Task.TypeOfTask.Milestone : Task.TypeOfTask.Task);

                    Program.dbms.UpdateTask(cur);
                    Program.dbms.UnselectAllEmployeesFromTask(taskID);
                    List<int> lst = GetSelectedEmployees();
                    if (lst == null) return;
                    Program.dbms.SetEmployeesOnTask(taskID, lst);
                    
                    ReloadTasksList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unable to add to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Something went wrong!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<int> GetSelectedEmployees()
        {
            List<int> lst = new List<int>();
            foreach(ListViewItem lvi in lstSelectedEmployees.Items)
            {
                lst.Add(int.Parse(lvi.Text));
                if (int.Parse(lvi.SubItems[2].Text) < ownerProject.NumberHrsPerDay)
                {
                    MessageBox.Show($"Employee {lvi.SubItems[1].Text}'s working hours per day are not suffient for this project.", "Working Hours", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
            }
            return lst;
        }
        private void trvTasks_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (trvTasks.SelectedNode.Tag == null)
                SetEntryToAdd();
            else
                SetEntryToEdit((Task)trvTasks.SelectedNode.Tag);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (trvTasks.SelectedNode == null || trvTasks.SelectedNode.Tag == null) return;
            try
            {
                if (MessageBox.Show("Are you sure you want to delete the selected task?", "Attention",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Program.dbms.RemoveTask(((Task)trvTasks.SelectedNode.Tag).ID);
                    ReloadTasksList();
                    SetEntryToAdd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete from database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectEmployee_Click(object sender, EventArgs e)
        {
            ListViewItem v = lstEmployees.SelectedItems[0];
            lstEmployees.Items.Remove(v);
            lstSelectedEmployees.Items.Add(v);
        }

        private void btnUnselectEmployee_Click(object sender, EventArgs e)
        {
            ListViewItem v = lstSelectedEmployees.SelectedItems[0];
            lstSelectedEmployees.Items.Remove(v);
            lstEmployees.Items.Add(v);
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            numWorkingHours.Value = Math.Max(numWorkingHours.Minimum, (dtpDueDate.Value - dtpStartDate.Value).Days * 8);
        }

        private void chkIsMilestone_CheckedChanged(object sender, EventArgs e)
        {
            dtpDueDate.Enabled = !chkIsMilestone.Checked;
        }
    }
}
