namespace BookManageApp_Access
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1236, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 51);
            this.button3.TabIndex = 1;
            this.button3.Text = "查询ISBN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1236, 639);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 51);
            this.button4.TabIndex = 1;
            this.button4.Text = "查询书名";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(994, 560);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 28);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(994, 652);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 28);
            this.textBox2.TabIndex = 2;
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
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.dataGridViewBook);
            this.Name = "FormBookMS";
            this.Text = "图书管理页面";
            this.Load += new System.EventHandler(this.FormBookMS_Load);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
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