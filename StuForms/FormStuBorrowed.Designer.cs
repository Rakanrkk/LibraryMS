namespace BookManageApp_Access.StuForms
{
    partial class FormStuBorrowed
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
            this.dataGridViewBookBorrowed = new System.Windows.Forms.DataGridView();
            this.buttonReturnBook = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookBorrowed)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookBorrowed
            // 
            this.dataGridViewBookBorrowed.AllowUserToAddRows = false;
            this.dataGridViewBookBorrowed.AllowUserToDeleteRows = false;
            this.dataGridViewBookBorrowed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookBorrowed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dataGridViewBookBorrowed.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewBookBorrowed.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewBookBorrowed.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBookBorrowed.MultiSelect = false;
            this.dataGridViewBookBorrowed.Name = "dataGridViewBookBorrowed";
            this.dataGridViewBookBorrowed.ReadOnly = true;
            this.dataGridViewBookBorrowed.RowHeadersVisible = false;
            this.dataGridViewBookBorrowed.RowHeadersWidth = 62;
            this.dataGridViewBookBorrowed.RowTemplate.Height = 30;
            this.dataGridViewBookBorrowed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookBorrowed.Size = new System.Drawing.Size(1032, 928);
            this.dataGridViewBookBorrowed.TabIndex = 1;
            this.dataGridViewBookBorrowed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookBorrowed_CellContentClick);
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.Location = new System.Drawing.Point(1108, 629);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(196, 111);
            this.buttonReturnBook.TabIndex = 2;
            this.buttonReturnBook.Text = "归还图书";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            this.buttonReturnBook.Click += new System.EventHandler(this.buttonReturnBook_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ISBN";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "书名";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "作者";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "出版社";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "借阅时间";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "是否归还";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormStuBorrowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 928);
            this.Controls.Add(this.buttonReturnBook);
            this.Controls.Add(this.dataGridViewBookBorrowed);
            this.Name = "FormStuBorrowed";
            this.Text = "已借阅的图书";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookBorrowed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBookBorrowed;
        private System.Windows.Forms.Button buttonReturnBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
    }
}