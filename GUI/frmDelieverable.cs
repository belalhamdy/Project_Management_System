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
        int projectID;
        public frmDelieverable(int projectID)
        {
            this.projectID = projectID;
            InitializeComponent();
        }

        private void frmDelieverable_Load(object sender, EventArgs e)
        {

        }
    }
}
