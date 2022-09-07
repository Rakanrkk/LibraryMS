namespace BookManageApp_Access.AdminForms.AdminManageForms
{
    partial class FormAdminMS
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
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddAdmin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDeleteAdmin = new System.Windows.Forms.Button();
            this.buttonSearchId = new System.Windows.Forms.Button();
            this.textBoxSearchId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AllowUserToAddRows = false;
            this.dataGridViewAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewAdmin.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAdmin.MultiSelect = false;
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.ReadOnly = true;
            this.dataGridViewAdmin.RowHeadersVisible = false;
            this.dataGridViewAdmin.RowHeadersWidth = 62;
            this.dataGridViewAdmin.RowTemplate.Height = 30;
            this.dataGridViewAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(912, 875);
            this.dataGridViewAdmin.TabIndex = 0;
            this.dataGridViewAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellContentClick);
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
            // buttonAddAdmin
            // 
            this.buttonAddAdmin.Location = new System.Drawing.Point(1074, 114);
            this.buttonAddAdmin.Name = "buttonAddAdmin";
            this.buttonAddAdmin.Size = new System.Drawing.Size(153, 73);
            this.buttonAddAdmin.TabIndex = 1;
            this.buttonAddAdmin.Text = "添加管理员";
            this.buttonAddAdmin.UseVisualStyleBackColor = true;
            this.buttonAddAdmin.Click += new System.EventHandler(this.buttonAddAdmin_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1074, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "编辑管理员";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonEditAdmin_Click);
            // 
            // buttonDeleteAdmin
            // 
            this.buttonDeleteAdmin.Location = new System.Drawing.Point(1074, 227);
            this.buttonDeleteAdmin.Name = "buttonDeleteAdmin";
            this.buttonDeleteAdmin.Size = new System.Drawing.Size(153, 73);
            this.buttonDeleteAdmin.TabIndex = 1;
            this.buttonDeleteAdmin.Text = "删除管理员";
            this.buttonDeleteAdmin.UseVisualStyleBackColor = true;
            this.buttonDeleteAdmin.Click += new System.EventHandler(this.buttonDeleteAdmin_Click);
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
            // FormAdminMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 875);
            this.Controls.Add(this.textBoxSearchId);
            this.Controls.Add(this.buttonSearchId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDeleteAdmin);
            this.Controls.Add(this.buttonAddAdmin);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Name = "FormAdminMS";
            this.Text = "管理员管理页面";
            this.Load += new System.EventHandler(this.FormAdminMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Button buttonAddAdmin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDeleteAdmin;
        private System.Windows.Forms.Button buttonSearchId;
        private System.Windows.Forms.TextBox textBoxSearchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}