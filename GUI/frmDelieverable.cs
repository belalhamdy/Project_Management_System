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
    public partial class frmDelieverable : Form
    {
        enum EntryMode
        {
            Add, Edit
        }
        private EntryMode currentMode;

        int projectID;
        public frmDelieverable(int projectID)
        {
            this.projectID = projectID;
            InitializeComponent();
        }

        private void frmDelieverable_Load(object sender, EventArgs e)
        {
            ReloadDeliverablesList();
        }

        private void ReloadDeliverablesList()
        {
            List<Deliverable> retrieved = Program.dbms.GetProjectDeliverables(projectID);
            lstDelieverables.Items.Clear();
            foreach (var del in retrieved)
            {
                var lvi = new ListViewItem(del.ID.ToString());
                lvi.SubItems.Add(del.Title);
                lvi.SubItems.Add(del.Description);
                lvi.SubItems.Add(del.IsFinished?"Yes":"No");
                lstDelieverables.Items.Add(lvi);
            }
            SetEntryToAdd();
        }

        private void lstDelieverables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDelieverables.SelectedIndices.Count == 0)
                SetEntryToAdd();
            else
                SetEntryToEdit(int.Parse(lstDelieverables.SelectedItems[0].Text));
        }

        private void SetEntryToEdit(int delieverabeID)
        {
            if (lstDelieverables.SelectedIndices.Count == 0)
            {
                SetEntryToAdd();
                return;
            }
            btnDeleteSelected.Enabled = true;
            currentMode = EntryMode.Edit;
            Deliverable ret = Program.dbms.GetDeliverableByID(int.Parse(lstDelieverables.SelectedItems[0].Text));
            txtName.Text = ret.Title;
            txtDescription.Text = ret.Description;
            chkFinished.Checked = ret.IsFinished;
            btnAddEdit.Text = "Edit";
        }

        private void SetEntryToAdd()
        {
            btnDeleteSelected.Enabled = false;
            currentMode = EntryMode.Add;
            txtName.Clear();
            txtDescription.Clear();
            chkFinished.Checked = false;
            btnAddEdit.Text = "Add";
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text.Trim();
            txtDescription.Text = txtDescription.Text.Trim();
            if (txtName.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Name and Description cannot be empty!", "Invalid Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try {
                if (currentMode == EntryMode.Add)
                {
                    Program.dbms.AddDeliverable(new Deliverable(projectID, chkFinished.Checked, txtName.Text, txtDescription.Text));
                }
                else
                {
                    if (lstDelieverables.SelectedIndices.Count == 0) return;
                    int id = int.Parse(lstDelieverables.SelectedItems[0].Text);
                    Program.dbms.UpdateDeliverable(new Deliverable(id, projectID, chkFinished.Checked, txtName.Text, txtDescription.Text));
                }
                ReloadDeliverablesList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to write to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SetEntryToAdd();
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (lstDelieverables.SelectedIndices.Count == 0) return;
            int id = int.Parse(lstDelieverables.SelectedItems[0].Text);
            try
            {
                Program.dbms.RemoveDeliverable(id);
                ReloadDeliverablesList();
            }catch(Exception ex)
            {
                MessageBox.Show("Unable to remove from database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
