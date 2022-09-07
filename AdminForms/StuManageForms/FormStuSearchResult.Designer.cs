namespace BookManageApp_Access.AdminForms.StuManageForms
{
    partial class FormStuSearchResult
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
            this.dataGridViewResultStu = new System.Windows.Forms.DataGridView();
            this.buttonDeleteStu = new System.Windows.Forms.Button();
            this.buttonEditStu = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultStu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResultStu
            // 
            this.dataGridViewResultStu.AllowUserToAddRows = false;
            this.dataGridViewResultStu.AllowUserToDeleteRows = false;
            this.dataGridViewResultStu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResultStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultStu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewResultStu.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewResultStu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewResultStu.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewResultStu.MultiSelect = false;
            this.dataGridViewResultStu.Name = "dataGridViewResultStu";
            this.dataGridViewResultStu.ReadOnly = true;
            this.dataGridViewResultStu.RowHeadersVisible = false;
            this.dataGridViewResultStu.RowHeadersWidth = 62;
            this.dataGridViewResultStu.RowTemplate.Height = 30;
            this.dataGridViewResultStu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResultStu.Size = new System.Drawing.Size(1070, 889);
            this.dataGridViewResultStu.TabIndex = 3;
            this.dataGridViewResultStu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStu_CellContentClick);
            // 
            // buttonDeleteStu
            // 
            this.buttonDeleteStu.Location = new System.Drawing.Point(1138, 282);
            this.buttonDeleteStu.Name = "buttonDeleteStu";
            this.buttonDeleteStu.Size = new System.Drawing.Size(153, 73);
            this.buttonDeleteStu.TabIndex = 7;
            this.buttonDeleteStu.Text = "删除学生";
            this.buttonDeleteStu.UseVisualStyleBackColor = true;
            this.buttonDeleteStu.Click += new System.EventHandler(this.buttonDeleteStu_Click);
            // 
            // buttonEditStu
            // 
            this.buttonEditStu.Location = new System.Drawing.Point(1138, 443);
            this.buttonEditStu.Name = "buttonEditStu";
            this.buttonEditStu.Size = new System.Drawing.Size(153, 73);
            this.buttonEditStu.TabIndex = 6;
            this.buttonEditStu.Text = "编辑学生";
            this.buttonEditStu.UseVisualStyleBackColor = true;
            this.buttonEditStu.Click += new System.EventHandler(this.buttonEditStu_Click);
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
            this.Column2.HeaderText = "psw";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "name";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FormStuSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 889);
            this.Controls.Add(this.buttonEditStu);
            this.Controls.Add(this.buttonDeleteStu);
            this.Controls.Add(this.dataGridViewResultStu);
            this.Name = "FormStuSearchResult";
            this.Text = "FormStuSearchResult";
            this.Load += new System.EventHandler(this.FormStuSearchResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultStu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewResultStu;
        private System.Windows.Forms.Button buttonDeleteStu;
        private System.Windows.Forms.Button buttonEditStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}