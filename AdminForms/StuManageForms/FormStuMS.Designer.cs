namespace BookManageApp_Access.AdminForms.StuManageForms
{
    partial class FormStuMS
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
            this.dataGridViewStu = new System.Windows.Forms.DataGridView();
            this.buttonAddStu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDeleteStu = new System.Windows.Forms.Button();
            this.buttonSearchId = new System.Windows.Forms.Button();
            this.textBoxSearchId = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStu
            // 
            this.dataGridViewStu.AllowUserToAddRows = false;
            this.dataGridViewStu.AllowUserToDeleteRows = false;
            this.dataGridViewStu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewStu.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewStu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewStu.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStu.MultiSelect = false;
            this.dataGridViewStu.Name = "dataGridViewStu";
            this.dataGridViewStu.ReadOnly = true;
            this.dataGridViewStu.RowHeadersVisible = false;
            this.dataGridViewStu.RowHeadersWidth = 62;
            this.dataGridViewStu.RowTemplate.Height = 30;
            this.dataGridViewStu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStu.Size = new System.Drawing.Size(912, 875);
            this.dataGridViewStu.TabIndex = 0;
            this.dataGridViewStu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStu_CellContentClick);
            // 
            // buttonAddStu
            // 
            this.buttonAddStu.Location = new System.Drawing.Point(1074, 114);
            this.buttonAddStu.Name = "buttonAddStu";
            this.buttonAddStu.Size = new System.Drawing.Size(153, 73);
            this.buttonAddStu.TabIndex = 1;
            this.buttonAddStu.Text = "添加学生";
            this.buttonAddStu.UseVisualStyleBackColor = true;
            this.buttonAddStu.Click += new System.EventHandler(this.buttonAddStu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1074, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "编辑学生";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonEditStu_Click);
            // 
            // buttonDeleteStu
            // 
            this.buttonDeleteStu.Location = new System.Drawing.Point(1074, 227);
            this.buttonDeleteStu.Name = "buttonDeleteStu";
            this.buttonDeleteStu.Size = new System.Drawing.Size(153, 73);
            this.buttonDeleteStu.TabIndex = 1;
            this.buttonDeleteStu.Text = "删除学生";
            this.buttonDeleteStu.UseVisualStyleBackColor = true;
            this.buttonDeleteStu.Click += new System.EventHandler(this.buttonDeleteStu_Click);
            // 
            // buttonSearchId
            // 
            this.buttonSearchId.Location = new System.Drawing.Point(1242, 619);
            this.buttonSearchId.Name = "buttonSearchId";
            this.buttonSearchId.Size = new System.Drawing.Size(99, 51);
            this.buttonSearchId.TabIndex = 1;
            this.buttonSearchId.Text = "查询Id";
            this.buttonSearchId.UseVisualStyleBackColor = true;
            this.buttonSearchId.Click += new System.EventHandler(this.buttonSearchId_Click);
            // 
            // textBoxSearchId
            // 
            this.textBoxSearchId.Location = new System.Drawing.Point(1000, 632);
            this.textBoxSearchId.Name = "textBoxSearchId";
            this.textBoxSearchId.Size = new System.Drawing.Size(207, 28);
            this.textBoxSearchId.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Psw";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FormStuMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 875);
            this.Controls.Add(this.textBoxSearchId);
            this.Controls.Add(this.buttonSearchId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDeleteStu);
            this.Controls.Add(this.buttonAddStu);
            this.Controls.Add(this.dataGridViewStu);
            this.Name = "FormStuMS";
            this.Text = "学生管理页面";
            this.Load += new System.EventHandler(this.FormStuMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStu;
        private System.Windows.Forms.Button buttonAddStu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDeleteStu;
        private System.Windows.Forms.Button buttonSearchId;
        private System.Windows.Forms.TextBox textBoxSearchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}