namespace BookManageApp_Access.AdminForms.BookManageForms
{
    partial class FormBookMS
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonSearchISBN = new System.Windows.Forms.Button();
            this.buttonSearchTitle = new System.Windows.Forms.Button();
            this.textBoxSearchISBN = new System.Windows.Forms.TextBox();
            this.textBoxSearchTitle = new System.Windows.Forms.TextBox();
            this.database1DataSet = new BookManageApp_Access.DB.Database1DataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new BookManageApp_Access.DB.Database1DataSetTableAdapters.bookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.AllowUserToAddRows = false;
            this.dataGridViewBook.AllowUserToDeleteRows = false;
            this.dataGridViewBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewBook.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBook.MultiSelect = false;
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.ReadOnly = true;
            this.dataGridViewBook.RowHeadersVisible = false;
            this.dataGridViewBook.RowHeadersWidth = 62;
            this.dataGridViewBook.RowTemplate.Height = 30;
            this.dataGridViewBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBook.Size = new System.Drawing.Size(912, 875);
            this.dataGridViewBook.TabIndex = 0;
            this.dataGridViewBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBook_CellContentClick);
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
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(1074, 114);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(153, 73);
            this.buttonAddBook.TabIndex = 1;
            this.buttonAddBook.Text = "添加书籍";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1074, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "编辑书籍";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonEditBook_Click);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(1074, 227);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(153, 73);
            this.buttonDeleteBook.TabIndex = 1;
            this.buttonDeleteBook.Text = "删除书籍";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonSearchISBN
            // 
            this.buttonSearchISBN.Location = new System.Drawing.Point(1236, 547);
            this.buttonSearchISBN.Name = "buttonSearchISBN";
            this.buttonSearchISBN.Size = new System.Drawing.Size(99, 51);
            this.buttonSearchISBN.TabIndex = 1;
            this.buttonSearchISBN.Text = "查询ISBN";
            this.buttonSearchISBN.UseVisualStyleBackColor = true;
            this.buttonSearchISBN.Click += new System.EventHandler(this.buttonSearchISBN_Click);
            // 
            // buttonSearchTitle
            // 
            this.buttonSearchTitle.Location = new System.Drawing.Point(1236, 639);
            this.buttonSearchTitle.Name = "buttonSearchTitle";
            this.buttonSearchTitle.Size = new System.Drawing.Size(99, 51);
            this.buttonSearchTitle.TabIndex = 1;
            this.buttonSearchTitle.Text = "查询书名";
            this.buttonSearchTitle.UseVisualStyleBackColor = true;
            this.buttonSearchTitle.Click += new System.EventHandler(this.buttonSearchTitle_Click);
            // 
            // textBoxSearchISBN
            // 
            this.textBoxSearchISBN.Location = new System.Drawing.Point(994, 560);
            this.textBoxSearchISBN.Name = "textBoxSearchISBN";
            this.textBoxSearchISBN.Size = new System.Drawing.Size(207, 28);
            this.textBoxSearchISBN.TabIndex = 2;
            // 
            // textBoxSearchTitle
            // 
            this.textBoxSearchTitle.Location = new System.Drawing.Point(994, 652);
            this.textBoxSearchTitle.Name = "textBoxSearchTitle";
            this.textBoxSearchTitle.Size = new System.Drawing.Size(207, 28);
            this.textBoxSearchTitle.TabIndex = 2;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.database1DataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // FormBookMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 875);
            this.Controls.Add(this.textBoxSearchTitle);
            this.Controls.Add(this.textBoxSearchISBN);
            this.Controls.Add(this.buttonSearchTitle);
            this.Controls.Add(this.buttonSearchISBN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.dataGridViewBook);
            this.Name = "FormBookMS";
            this.Text = "图书管理页面";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonSearchISBN;
        private System.Windows.Forms.Button buttonSearchTitle;
        private System.Windows.Forms.TextBox textBoxSearchISBN;
        private System.Windows.Forms.TextBox textBoxSearchTitle;
        private DB.Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private DB.Database1DataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}