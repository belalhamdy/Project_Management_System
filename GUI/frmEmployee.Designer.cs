namespace Project_Management_System
{
    partial class EmployeeForm
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
            this.EmployeeLView = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddtBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.WorkingHTxt = new System.Windows.Forms.TextBox();
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeLView
            // 
            this.EmployeeLView.HideSelection = false;
            this.EmployeeLView.Location = new System.Drawing.Point(13, 13);
            this.EmployeeLView.Name = "EmployeeLView";
            this.EmployeeLView.Size = new System.Drawing.Size(775, 281);
            this.EmployeeLView.TabIndex = 0;
            this.EmployeeLView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TitleTxt);
            this.groupBox1.Controls.Add(this.WorkingHTxt);
            this.groupBox1.Controls.Add(this.NameTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddtBtn);
            this.groupBox1.Location = new System.Drawing.Point(13, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Data";
            // 
            // AddtBtn
            // 
            this.AddtBtn.Location = new System.Drawing.Point(6, 109);
            this.AddtBtn.Name = "AddtBtn";
            this.AddtBtn.Size = new System.Drawing.Size(763, 23);
            this.AddtBtn.TabIndex = 0;
            this.AddtBtn.Text = "Add";
            this.AddtBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Working Hours/Day :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Position Title :";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(53, 27);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(298, 20);
            this.NameTxt.TabIndex = 4;
            // 
            // WorkingHTxt
            // 
            this.WorkingHTxt.Location = new System.Drawing.Point(471, 27);
            this.WorkingHTxt.Name = "WorkingHTxt";
            this.WorkingHTxt.Size = new System.Drawing.Size(298, 20);
            this.WorkingHTxt.TabIndex = 5;
            // 
            // TitleTxt
            // 
            this.TitleTxt.Location = new System.Drawing.Point(85, 67);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(684, 20);
            this.TitleTxt.TabIndex = 6;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EmployeeLView);
            this.Name = "EmployeeForm";
            this.Text = "Project Management";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView EmployeeLView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddtBtn;
        private System.Windows.Forms.TextBox TitleTxt;
        private System.Windows.Forms.TextBox WorkingHTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

