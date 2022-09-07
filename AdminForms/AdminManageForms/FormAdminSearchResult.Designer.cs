namespace BookManageApp_Access.AdminForms.AdminManageForms
{
    partial class FormAdminSearchResult
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
            this.dataGridViewResultAdmin = new System.Windows.Forms.DataGridView();
            this.buttonDeleteAdmin = new System.Windows.Forms.Button();
            this.buttonEditAdmin = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResultAdmin
            // 
            this.dataGridViewResultAdmin.AllowUserToAddRows = false;
            this.dataGridViewResultAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewResultAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResultAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewResultAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewResultAdmin.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewResultAdmin.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewResultAdmin.MultiSelect = false;
            this.dataGridViewResultAdmin.Name = "dataGridViewResultAdmin";
            this.dataGridViewResultAdmin.ReadOnly = true;
            this.dataGridViewResultAdmin.RowHeadersVisible = false;
            this.dataGridViewResultAdmin.RowHeadersWidth = 62;
            this.dataGridViewResultAdmin.RowTemplate.Height = 30;
            this.dataGridViewResultAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResultAdmin.Size = new System.Drawing.Size(1070, 889);
            this.dataGridViewResultAdmin.TabIndex = 3;
            this.dataGridViewResultAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellContentClick);
            // 
            // buttonDeleteAdmin
            // 
            this.buttonDeleteAdmin.Location = new System.Drawing.Point(1138, 282);
            this.buttonDeleteAdmin.Name = "buttonDeleteAdmin";
            this.buttonDeleteAdmin.Size = new System.Drawing.Size(153, 73);
            this.buttonDeleteAdmin.TabIndex = 7;
            this.buttonDeleteAdmin.Text = "删除管理员";
            this.buttonDeleteAdmin.UseVisualStyleBackColor = true;
            this.buttonDeleteAdmin.Click += new System.EventHandler(this.buttonDeleteAdmin_Click);
            // 
            // buttonEditAdmin
            // 
            this.buttonEditAdmin.Location = new System.Drawing.Point(1138, 443);
            this.buttonEditAdmin.Name = "buttonEditAdmin";
            this.buttonEditAdmin.Size = new System.Drawing.Size(153, 73);
            this.buttonEditAdmin.TabIndex = 6;
            this.buttonEditAdmin.Text = "编辑管理员";
            this.buttonEditAdmin.UseVisualStyleBackColor = true;
            this.buttonEditAdmin.Click += new System.EventHandler(this.buttonEditAdmin_Click);
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
            // FormAdminSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 889);
            this.Controls.Add(this.buttonEditAdmin);
            this.Controls.Add(this.buttonDeleteAdmin);
            this.Controls.Add(this.dataGridViewResultAdmin);
            this.Name = "FormAdminSearchResult";
            this.Text = "FormAdminSearchResult";
            this.Load += new System.EventHandler(this.FormAdminSearchResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewResultAdmin;
        private System.Windows.Forms.Button buttonDeleteAdmin;
        private System.Windows.Forms.Button buttonEditAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}