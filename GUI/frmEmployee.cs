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

namespace Project_Management_System.GUI
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            ReloadEmployeesList();
        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteSelected.Enabled = lstEmployees.SelectedIndices.Count != 0;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text.Trim();
            txtTitle.Text = txtTitle.Text.Trim();
            if (txtName.Text == "" || txtTitle.Text == "")
            {
                MessageBox.Show("Name and Title cannot be empty!", "Invalid Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Program.dbms.AddEmployee(new Employee(txtName.Text, txtTitle.Text, (int)numHours.Value, (int)numCost.Value, null));
                ReloadEmployeesList();

                txtName.Clear();
                txtTitle.Clear();
                numCost.Value = numCost.Minimum;
                numHours.Value = numHours.Minimum;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to write to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedIndices.Count == 0) return;
            try
            {
                if (MessageBox.Show("Are you sure you want to delete the selected employee?", "Attention",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Program.dbms.RemoveEmployee(int.Parse(lstEmployees.SelectedItems[0].Text));
                    ReloadEmployeesList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete from database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ReloadEmployeesList()
        {
            List<Employee> retrieved = Program.dbms.GetAllEmployees();
            lstEmployees.Items.Clear();
            foreach (var emp in retrieved)
            {
                var lvi = new ListViewItem(emp.ID.ToString());
                lvi.SubItems.Add(emp.Name);
                lvi.SubItems.Add(emp.Title);
                lvi.SubItems.Add(emp.HoursDay.ToString());
                lvi.SubItems.Add(emp.Cost.ToString());
                lstEmployees.Items.Add(lvi);
            }
        }
    }

}
