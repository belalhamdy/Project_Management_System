namespace Project_Management_System.GUI
{
    partial class frmProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.btnStartPlanning = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditDelieverables = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstProjects = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStartDay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numWorkingHours = new System.Windows.Forms.NumericUpDown();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnChartFinish = new System.Windows.Forms.Button();
            this.btnChartStart = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkingHours)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProjectName
            // 
            this.txtProjectName.AccessibleName = "";
            this.txtProjectName.Location = new System.Drawing.Point(89, 19);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(260, 20);
            this.txtProjectName.TabIndex = 1;
            // 
            // btnStartPlanning
            // 
            this.btnStartPlanning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartPlanning.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartPlanning.Enabled = false;
            this.btnStartPlanning.Location = new System.Drawing.Point(6, 321);
            this.btnStartPlanning.Name = "btnStartPlanning";
            this.btnStartPlanning.Size = new System.Drawing.Size(557, 23);
            this.btnStartPlanning.TabIndex = 1;
            this.btnStartPlanning.Text = "Start Planning Selected Project";
            this.btnStartPlanning.UseVisualStyleBackColor = false;
            this.btnStartPlanning.Click += new System.EventHandler(this.btnStartPlanning_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Project Name: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnEditDelieverables);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.lstProjects);
            this.groupBox2.Controls.Add(this.btnStartPlanning);
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 414);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Projects";
            // 
            // btnEditDelieverables
            // 
            this.btnEditDelieverables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDelieverables.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditDelieverables.Enabled = false;
            this.btnEditDelieverables.Location = new System.Drawing.Point(6, 356);
            this.btnEditDelieverables.Name = "btnEditDelieverables";
            this.btnEditDelieverables.Size = new System.Drawing.Size(557, 23);
            this.btnEditDelieverables.TabIndex = 3;
            this.btnEditDelieverables.Text = "Edit Delieverables for selected project";
            this.btnEditDelieverables.UseVisualStyleBackColor = false;
            this.btnEditDelieverables.Click += new System.EventHandler(this.btnEditDelieverables_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(6, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(557, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Selected Project";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstProjects
            // 
            this.lstProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.lstProjects.FullRowSelect = true;
            this.lstProjects.HideSelection = false;
            this.lstProjects.Location = new System.Drawing.Point(6, 19);
            this.lstProjects.MultiSelect = false;
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(557, 296);
            this.lstProjects.TabIndex = 0;
            this.lstProjects.UseCompatibleStateImageBehavior = false;
            this.lstProjects.View = System.Windows.Forms.View.Details;
            this.lstProjects.SelectedIndexChanged += new System.EventHandler(this.lstEmployees_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Project Name";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Starting Date";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Due Date";
            this.columnHeader4.Width = 72;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hours/Day";
            this.columnHeader5.Width = 76;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Week Start";
            this.columnHeader7.Width = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Project Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStartDay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numWorkingHours);
            this.groupBox1.Controls.Add(this.dtpDueDate);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAddProject);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProjectName);
            this.groupBox1.Location = new System.Drawing.Point(12, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Project";
            // 
            // cmbStartDay
            // 
            this.cmbStartDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartDay.FormattingEnabled = true;
            this.cmbStartDay.Items.AddRange(new object[] {
            "Saturday",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cmbStartDay.Location = new System.Drawing.Point(442, 72);
            this.cmbStartDay.Name = "cmbStartDay";
            this.cmbStartDay.Size = new System.Drawing.Size(121, 21);
            this.cmbStartDay.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Starting Day of the Week:";
            // 
            // numWorkingHours
            // 
            this.numWorkingHours.Location = new System.Drawing.Point(442, 46);
            this.numWorkingHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numWorkingHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWorkingHours.Name = "numWorkingHours";
            this.numWorkingHours.Size = new System.Drawing.Size(121, 20);
            this.numWorkingHours.TabIndex = 3;
            this.numWorkingHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(89, 71);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(194, 20);
            this.dtpDueDate.TabIndex = 7;
            this.dtpDueDate.ValueChanged += new System.EventHandler(this.dtpDueDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(89, 45);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(194, 20);
            this.dtpStartDate.TabIndex = 5;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Working Hours/Day:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Due Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Starting Date:";
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddProject.Location = new System.Drawing.Point(9, 99);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(554, 23);
            this.btnAddProject.TabIndex = 12;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = false;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmployees.Location = new System.Drawing.Point(12, 603);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(576, 23);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.Text = "Manage Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnChartFinish
            // 
            this.btnChartFinish.Location = new System.Drawing.Point(320, 639);
            this.btnChartFinish.Margin = new System.Windows.Forms.Padding(2);
            this.btnChartFinish.Name = "btnChartFinish";
            this.btnChartFinish.Size = new System.Drawing.Size(268, 24);
            this.btnChartFinish.TabIndex = 4;
            this.btnChartFinish.Text = "Show Gantt Shart After Finish";
            this.btnChartFinish.UseVisualStyleBackColor = true;
            this.btnChartFinish.Click += new System.EventHandler(this.btnChartFinish_Click);
            // 
            // btnChartStart
            // 
            this.btnChartStart.Location = new System.Drawing.Point(12, 639);
            this.btnChartStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnChartStart.Name = "btnChartStart";
            this.btnChartStart.Size = new System.Drawing.Size(268, 24);
            this.btnChartStart.TabIndex = 5;
            this.btnChartStart.Text = "Show Gantt Shart Before Start";
            this.btnChartStart.UseVisualStyleBackColor = true;
            this.btnChartStart.Click += new System.EventHandler(this.btnChartStart_Click);
            // 
            // frmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 674);
            this.Controls.Add(this.btnChartStart);
            this.Controls.Add(this.btnChartFinish);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Management";
            this.Load += new System.EventHandler(this.frmProject_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkingHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Button btnStartPlanning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.NumericUpDown numWorkingHours;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStartDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnEditDelieverables;
        private System.Windows.Forms.Button btnChartFinish;
        private System.Windows.Forms.Button btnChartStart;
    }
}