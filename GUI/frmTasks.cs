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
    public partial class frmTasks : Form
    {
        private Project OwnerProject;
        public frmTasks(Project project)
        {
            this.OwnerProject = project;
            InitializeComponent();
        }

        private void MainTaskForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
