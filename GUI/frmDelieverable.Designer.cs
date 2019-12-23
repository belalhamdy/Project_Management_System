namespace Project_Management_System.GUI
{
    partial class frmDelieverable
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.chkFinished = new System.Windows.Forms.CheckBox();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.lstDelieverables = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lstDelieverables);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 484);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delieverables";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddNew);
            this.groupBox2.Controls.Add(this.chkFinished);
            this.groupBox2.Controls.Add(this.btnDeleteSelected);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAddEdit);
            this.groupBox2.Location = new System.Drawing.Point(6, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 167);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delieverable Data";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(275, -1);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // chkFinished
            // 
            this.chkFinished.AutoSize = true;
            this.chkFinished.Location = new System.Drawing.Point(275, 30);
            this.chkFinished.Name = "chkFinished";
            this.chkFinished.Size = new System.Drawing.Size(76, 17);
            this.chkFinished.TabIndex = 8;
            this.chkFinished.Text = "Is Finishd?";
            this.chkFinished.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Enabled = false;
            this.btnDeleteSelected.Location = new System.Drawing.Point(6, 138);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(345, 23);
            this.btnDeleteSelected.TabIndex = 7;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(85, 62);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(266, 20);
            this.txtDescription.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(53, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 20);
            this.txtName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description :";
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
            // btnAddEdit
            // 
            this.btnAddEdit.Location = new System.Drawing.Point(6, 109);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(345, 23);
            this.btnAddEdit.TabIndex = 0;
            this.btnAddEdit.Text = "Add";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // lstDelieverables
            // 
            this.lstDelieverables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstDelieverables.FullRowSelect = true;
            this.lstDelieverables.HideSelection = false;
            this.lstDelieverables.Location = new System.Drawing.Point(6, 19);
            this.lstDelieverables.MultiSelect = false;
            this.lstDelieverables.Name = "lstDelieverables";
            this.lstDelieverables.Size = new System.Drawing.Size(357, 281);
            this.lstDelieverables.TabIndex = 2;
            this.lstDelieverables.UseCompatibleStateImageBehavior = false;
            this.lstDelieverables.View = System.Windows.Forms.View.Details;
            this.lstDelieverables.SelectedIndexChanged += new System.EventHandler(this.lstDelieverables_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 42;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Is Finished";
            this.columnHeader4.Width = 77;
            // 
            // frmDelieverable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 505);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDelieverable";
            this.Text = "Project Management";
            this.Load += new System.EventHandler(this.frmDelieverable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.ListView lstDelieverables;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.CheckBox chkFinished;
        private System.Windows.Forms.Button btnAddNew;
    }
}

