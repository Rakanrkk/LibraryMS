namespace BookManageApp_Access.StuForms
{ 
     partial class FormStuBookSearchResult
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
            this.dataGridViewResultBook = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBorrowBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResultBook
            // 
            this.dataGridViewResultBook.AllowUserToAddRows = false;
            this.dataGridViewResultBook.AllowUserToDeleteRows = false;
            this.dataGridViewResultBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResultBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewResultBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewResultBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewResultBook.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewResultBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewResultBook.MultiSelect = false;
            this.dataGridViewResultBook.Name = "dataGridViewResultBook";
            this.dataGridViewResultBook.ReadOnly = true;
            this.dataGridViewResultBook.RowHeadersVisible = false;
            this.dataGridViewResultBook.RowHeadersWidth = 62;
            this.dataGridViewResultBook.RowTemplate.Height = 30;
            this.dataGridViewResultBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResultBook.Size = new System.Drawing.Size(951, 741);
            this.dataGridViewResultBook.TabIndex = 3;
            this.dataGridViewResultBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBook_CellContentClick);
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
            // Column5
            // 
            this.Column5.HeaderText = "库存";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // buttonBorrowBook
            // 
            this.buttonBorrowBook.Location = new System.Drawing.Point(996, 220);
            this.buttonBorrowBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBorrowBook.Name = "buttonBorrowBook";
            this.buttonBorrowBook.Size = new System.Drawing.Size(151, 85);
            this.buttonBorrowBook.TabIndex = 4;
            this.buttonBorrowBook.Text = "借阅";
            this.buttonBorrowBook.UseVisualStyleBackColor = true;
            this.buttonBorrowBook.Click += new System.EventHandler(this.buttonBorrowBook_Click);
            // 
            // FormStuBookSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 741);
            this.Controls.Add(this.buttonBorrowBook);
            this.Controls.Add(this.dataGridViewResultBook);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStuBookSearchResult";
            this.Text = "FormStuBookSearchResult";
            this.Load += new System.EventHandler(this.FormBookSearchResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultBook)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.DataGridView dataGridViewResultBook;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button buttonBorrowBook;
    }
}