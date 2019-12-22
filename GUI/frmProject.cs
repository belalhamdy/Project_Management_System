using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Management_System.Entities;

namespace Project_Management_System.GUI
{
    public partial class frmProject : Form
    {
        public frmProject()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEmployee Employees = new frmEmployee();
            Employees.ShowDialog();
        }

        private void frmProject_Load(object sender, EventArgs e)
        {
            cmbStartDay.SelectedIndex = 0;
            ReloadProjectsList();
        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStartPlanning.Enabled = lstProjects.SelectedIndices.Count != 0;
            btnDelete.Enabled = lstProjects.SelectedIndices.Count != 0;
            btnEditDelieverables.Enabled = lstProjects.SelectedIndices.Count != 0;
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            txtProjectName.Text = txtProjectName.Text.Trim();
            if (txtProjectName.Text == "")
            {
                MessageBox.Show("Name of project cannot be empty!", "Invalid Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpStartDate.Value >= dtpDueDate.Value)
            {
                MessageBox.Show("Due Date of Project must be later than the start date", "Invalid Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Program.dbms.AddProject(
                        new Project(txtProjectName.Text,
                            dtpStartDate.Value, dtpDueDate.Value,
                            (int)numWorkingHours.Value,
                            cmbStartDay.SelectedIndex)
                        );
                ReloadProjectsList();
                txtProjectName.Clear();
                dtpStartDate.Value = dtpDueDate.Value = DateTime.Now;
                numWorkingHours.Value = numWorkingHours.Minimum;
                cmbStartDay.SelectedIndex = 0;
                
            }catch(Exception ex)
            {
                MessageBox.Show("Unable to add to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstProjects.SelectedIndices.Count == 0) return;
            try
            {
                if (MessageBox.Show("Are you sure you want to delete the selected project? This will delete all the tasks as well.", "Attention",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Program.dbms.RemoveProject(int.Parse(lstProjects.SelectedItems[0].Text));
                    ReloadProjectsList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete from database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnStartPlanning_Click(object sender, EventArgs e)
        {
            if (lstProjects.SelectedIndices.Count == 0) return;

            Project ret = Program.dbms.GetProjectByID(int.Parse(lstProjects.SelectedItems[0].Text));
            frmPlanning frm = new frmPlanning(ret);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void ReloadProjectsList()
        {
            List<Project> retrieved = Program.dbms.GetAllProjects();
            lstProjects.Items.Clear();
            foreach (var prj in retrieved)
            {
                var lvi = new ListViewItem(prj.ID.ToString());
                lvi.SubItems.Add(prj.ProjectName);
                lvi.SubItems.Add(prj.StartingDate.ToShortDateString());
                lvi.SubItems.Add(prj.DueDate.ToShortDateString());
                lvi.SubItems.Add(prj.NumberHrsPerDay.ToString());
                lvi.SubItems.Add(prj.Cost.ToString());
                lvi.SubItems.Add(cmbStartDay.Items[prj.StartingOfWeek].ToString());
                lstProjects.Items.Add(lvi);
            }
        }

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditDelieverables_Click(object sender, EventArgs e)
        {
            if (lstProjects.SelectedIndices.Count == 0) return;
            frmDelieverable frm = new frmDelieverable(int.Parse(lstProjects.SelectedItems[0].Text));
            frm.ShowDialog();
        }
    }
}
