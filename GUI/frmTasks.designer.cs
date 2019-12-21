namespace Project_Management_System.GUI
{
    partial class frmTasks
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TaskGroup = new System.Windows.Forms.GroupBox();
            this.numWorkingHours = new System.Windows.Forms.NumericUpDown();
            this.numActualWorkingHours = new System.Windows.Forms.NumericUpDown();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstSelectedEmployees = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.lstEmployees = new System.Windows.Forms.ListView();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstDependentTasks = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.trvTasks = new System.Windows.Forms.TreeView();
            this.btnSelectEmployee = new System.Windows.Forms.Button();
            this.btnUnselectEmployee = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.TaskGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkingHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numActualWorkingHours)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trvTasks);
            this.groupBox1.Controls.Add(this.TaskGroup);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 617);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tasks";
            // 
            // TaskGroup
            // 
            this.TaskGroup.Controls.Add(this.btnRemove);
            this.TaskGroup.Controls.Add(this.numWorkingHours);
            this.TaskGroup.Controls.Add(this.numActualWorkingHours);
            this.TaskGroup.Controls.Add(this.dtpDueDate);
            this.TaskGroup.Controls.Add(this.dtpStartDate);
            this.TaskGroup.Controls.Add(this.groupBox2);
            this.TaskGroup.Controls.Add(this.txtTitle);
            this.TaskGroup.Controls.Add(this.label6);
            this.TaskGroup.Controls.Add(this.lstDependentTasks);
            this.TaskGroup.Controls.Add(this.label5);
            this.TaskGroup.Controls.Add(this.label4);
            this.TaskGroup.Controls.Add(this.label3);
            this.TaskGroup.Controls.Add(this.label2);
            this.TaskGroup.Controls.Add(this.label1);
            this.TaskGroup.Controls.Add(this.btnAdd);
            this.TaskGroup.Location = new System.Drawing.Point(6, 287);
            this.TaskGroup.Name = "TaskGroup";
            this.TaskGroup.Size = new System.Drawing.Size(775, 324);
            this.TaskGroup.TabIndex = 4;
            this.TaskGroup.TabStop = false;
            this.TaskGroup.Text = "Task";
            // 
            // numWorkingHours
            // 
            this.numWorkingHours.Location = new System.Drawing.Point(318, 64);
            this.numWorkingHours.Name = "numWorkingHours";
            this.numWorkingHours.Size = new System.Drawing.Size(104, 20);
            this.numWorkingHours.TabIndex = 17;
            // 
            // numActualWorkingHours
            // 
            this.numActualWorkingHours.Location = new System.Drawing.Point(318, 97);
            this.numActualWorkingHours.Name = "numActualWorkingHours";
            this.numActualWorkingHours.Size = new System.Drawing.Size(104, 20);
            this.numActualWorkingHours.TabIndex = 16;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(81, 98);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(104, 20);
            this.dtpDueDate.TabIndex = 15;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(81, 62);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(104, 20);
            this.dtpStartDate.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUnselectEmployee);
            this.groupBox2.Controls.Add(this.btnSelectEmployee);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lstSelectedEmployees);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lstEmployees);
            this.groupBox2.Location = new System.Drawing.Point(9, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 134);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employees";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Selected Employees";
            // 
            // lstSelectedEmployees
            // 
            this.lstSelectedEmployees.HideSelection = false;
            this.lstSelectedEmployees.Location = new System.Drawing.Point(399, 38);
            this.lstSelectedEmployees.Name = "lstSelectedEmployees";
            this.lstSelectedEmployees.Size = new System.Drawing.Size(355, 90);
            this.lstSelectedEmployees.TabIndex = 16;
            this.lstSelectedEmployees.UseCompatibleStateImageBehavior = false;
            this.lstSelectedEmployees.View = System.Windows.Forms.View.Details;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Select Employees";
            // 
            // lstEmployees
            // 
            this.lstEmployees.HideSelection = false;
            this.lstEmployees.Location = new System.Drawing.Point(6, 38);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(356, 90);
            this.lstEmployees.TabIndex = 14;
            this.lstEmployees.UseCompatibleStateImageBehavior = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(39, 32);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(383, 20);
            this.txtTitle.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Dependant Tasks :";
            // 
            // lstDependentTasks
            // 
            this.lstDependentTasks.HideSelection = false;
            this.lstDependentTasks.Location = new System.Drawing.Point(432, 32);
            this.lstDependentTasks.Name = "lstDependentTasks";
            this.lstDependentTasks.Size = new System.Drawing.Size(337, 90);
            this.lstDependentTasks.TabIndex = 6;
            this.lstDependentTasks.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Actual Working Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Working Hours:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Due Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Starting Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(760, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // trvTasks
            // 
            this.trvTasks.Location = new System.Drawing.Point(6, 19);
            this.trvTasks.Name = "trvTasks";
            this.trvTasks.Size = new System.Drawing.Size(775, 262);
            this.trvTasks.TabIndex = 5;
            // 
            // btnSelectEmployee
            // 
            this.btnSelectEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectEmployee.Location = new System.Drawing.Point(368, 56);
            this.btnSelectEmployee.Name = "btnSelectEmployee";
            this.btnSelectEmployee.Size = new System.Drawing.Size(25, 25);
            this.btnSelectEmployee.TabIndex = 19;
            this.btnSelectEmployee.Text = ">";
            this.btnSelectEmployee.UseVisualStyleBackColor = true;
            // 
            // btnUnselectEmployee
            // 
            this.btnUnselectEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnselectEmployee.Location = new System.Drawing.Point(368, 87);
            this.btnUnselectEmployee.Name = "btnUnselectEmployee";
            this.btnUnselectEmployee.Size = new System.Drawing.Size(25, 25);
            this.btnUnselectEmployee.TabIndex = 20;
            this.btnUnselectEmployee.Text = "<";
            this.btnUnselectEmployee.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(9, 297);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(760, 23);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove Selected Tasks";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // MainTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 658);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainTaskForm";
            this.Text = "Project Management";
            this.Load += new System.EventHandler(this.MainTaskForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.TaskGroup.ResumeLayout(false);
            this.TaskGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkingHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numActualWorkingHours)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox TaskGroup;
        private System.Windows.Forms.NumericUpDown numWorkingHours;
        private System.Windows.Forms.NumericUpDown numActualWorkingHours;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lstSelectedEmployees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lstEmployees;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstDependentTasks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TreeView trvTasks;
        private System.Windows.Forms.Button btnUnselectEmployee;
        private System.Windows.Forms.Button btnSelectEmployee;
        private System.Windows.Forms.Button btnRemove;
    }
}