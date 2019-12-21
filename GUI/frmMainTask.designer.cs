namespace Project_Planner
{
    partial class MainTaskForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.TaskGroup = new System.Windows.Forms.GroupBox();
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DependantLView = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SelectEmLView = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.SelectedEmLView = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.StartDatePkr = new System.Windows.Forms.DateTimePicker();
            this.DuoDatePkr = new System.Windows.Forms.DateTimePicker();
            this.ActualWorkUD = new System.Windows.Forms.NumericUpDown();
            this.WorkHoursUD = new System.Windows.Forms.NumericUpDown();
            this.AddSubtaskBtn = new System.Windows.Forms.Button();
            this.TaskGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActualWorkUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkHoursUD)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(775, 261);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // TaskGroup
            // 
            this.TaskGroup.Controls.Add(this.AddSubtaskBtn);
            this.TaskGroup.Controls.Add(this.WorkHoursUD);
            this.TaskGroup.Controls.Add(this.ActualWorkUD);
            this.TaskGroup.Controls.Add(this.DuoDatePkr);
            this.TaskGroup.Controls.Add(this.StartDatePkr);
            this.TaskGroup.Controls.Add(this.groupBox2);
            this.TaskGroup.Controls.Add(this.TitleTxt);
            this.TaskGroup.Controls.Add(this.label6);
            this.TaskGroup.Controls.Add(this.DependantLView);
            this.TaskGroup.Controls.Add(this.label5);
            this.TaskGroup.Controls.Add(this.label4);
            this.TaskGroup.Controls.Add(this.label3);
            this.TaskGroup.Controls.Add(this.label2);
            this.TaskGroup.Controls.Add(this.label1);
            this.TaskGroup.Controls.Add(this.addBtn);
            this.TaskGroup.Location = new System.Drawing.Point(13, 281);
            this.TaskGroup.Name = "TaskGroup";
            this.TaskGroup.Size = new System.Drawing.Size(775, 299);
            this.TaskGroup.TabIndex = 1;
            this.TaskGroup.TabStop = false;
            this.TaskGroup.Text = "Task";
            // 
            // TitleTxt
            // 
            this.TitleTxt.Location = new System.Drawing.Point(39, 32);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(383, 20);
            this.TitleTxt.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Dependant Tasks :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // DependantLView
            // 
            this.DependantLView.HideSelection = false;
            this.DependantLView.Location = new System.Drawing.Point(432, 32);
            this.DependantLView.Name = "DependantLView";
            this.DependantLView.Size = new System.Drawing.Size(337, 90);
            this.DependantLView.TabIndex = 6;
            this.DependantLView.UseCompatibleStateImageBehavior = false;
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
            this.label4.Location = new System.Drawing.Point(201, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Working Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Due Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Starting Date";
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
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(410, 268);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(359, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add Task";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.SelectedEmLView);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SelectEmLView);
            this.groupBox2.Location = new System.Drawing.Point(9, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 134);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employees";
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
            // SelectEmLView
            // 
            this.SelectEmLView.HideSelection = false;
            this.SelectEmLView.Location = new System.Drawing.Point(6, 38);
            this.SelectEmLView.Name = "SelectEmLView";
            this.SelectEmLView.Size = new System.Drawing.Size(392, 90);
            this.SelectEmLView.TabIndex = 14;
            this.SelectEmLView.UseCompatibleStateImageBehavior = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Selected Employees";
            // 
            // SelectedEmLView
            // 
            this.SelectedEmLView.HideSelection = false;
            this.SelectedEmLView.Location = new System.Drawing.Point(423, 38);
            this.SelectedEmLView.Name = "SelectedEmLView";
            this.SelectedEmLView.Size = new System.Drawing.Size(331, 90);
            this.SelectedEmLView.TabIndex = 16;
            this.SelectedEmLView.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = ">";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(404, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "<";
            // 
            // StartDatePkr
            // 
            this.StartDatePkr.Location = new System.Drawing.Point(81, 62);
            this.StartDatePkr.Name = "StartDatePkr";
            this.StartDatePkr.Size = new System.Drawing.Size(104, 20);
            this.StartDatePkr.TabIndex = 14;
            // 
            // DuoDatePkr
            // 
            this.DuoDatePkr.Location = new System.Drawing.Point(81, 98);
            this.DuoDatePkr.Name = "DuoDatePkr";
            this.DuoDatePkr.Size = new System.Drawing.Size(104, 20);
            this.DuoDatePkr.TabIndex = 15;
            // 
            // ActualWorkUD
            // 
            this.ActualWorkUD.Location = new System.Drawing.Point(318, 102);
            this.ActualWorkUD.Name = "ActualWorkUD";
            this.ActualWorkUD.Size = new System.Drawing.Size(104, 20);
            this.ActualWorkUD.TabIndex = 16;
            // 
            // WorkHoursUD
            // 
            this.WorkHoursUD.Location = new System.Drawing.Point(318, 66);
            this.WorkHoursUD.Name = "WorkHoursUD";
            this.WorkHoursUD.Size = new System.Drawing.Size(104, 20);
            this.WorkHoursUD.TabIndex = 17;
            // 
            // AddSubtaskBtn
            // 
            this.AddSubtaskBtn.Location = new System.Drawing.Point(9, 268);
            this.AddSubtaskBtn.Name = "AddSubtaskBtn";
            this.AddSubtaskBtn.Size = new System.Drawing.Size(395, 23);
            this.AddSubtaskBtn.TabIndex = 18;
            this.AddSubtaskBtn.Text = "Add SubTask";
            this.AddSubtaskBtn.UseVisualStyleBackColor = true;
            // 
            // MainTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.TaskGroup);
            this.Controls.Add(this.listView1);
            this.Name = "MainTaskForm";
            this.Text = "Project Management";
            this.Load += new System.EventHandler(this.MainTaskForm_Load);
            this.TaskGroup.ResumeLayout(false);
            this.TaskGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActualWorkUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkHoursUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox TaskGroup;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView DependantLView;
        private System.Windows.Forms.TextBox TitleTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView SelectedEmLView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView SelectEmLView;
        private System.Windows.Forms.NumericUpDown WorkHoursUD;
        private System.Windows.Forms.NumericUpDown ActualWorkUD;
        private System.Windows.Forms.DateTimePicker DuoDatePkr;
        private System.Windows.Forms.DateTimePicker StartDatePkr;
        private System.Windows.Forms.Button AddSubtaskBtn;
    }
}