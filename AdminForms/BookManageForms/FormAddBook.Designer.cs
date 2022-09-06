namespace BookManageApp_Access.AdminForms.BookManageForms
{
    partial class FormAddBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBookAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBookPress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBookISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBookStock = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonCancalAddBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(213, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "书名：";
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBookTitle.Location = new System.Drawing.Point(373, 83);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(239, 37);
            this.textBoxBookTitle.TabIndex = 1;
            this.textBoxBookTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(213, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "作者：";
            // 
            // textBoxBookAuthor
            // 
            this.textBoxBookAuthor.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBookAuthor.Location = new System.Drawing.Point(373, 148);
            this.textBoxBookAuthor.Name = "textBoxBookAuthor";
            this.textBoxBookAuthor.Size = new System.Drawing.Size(239, 37);
            this.textBoxBookAuthor.TabIndex = 1;
            this.textBoxBookAuthor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(213, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "出版社：";
            // 
            // textBoxBookPress
            // 
            this.textBoxBookPress.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBookPress.Location = new System.Drawing.Point(373, 209);
            this.textBoxBookPress.Name = "textBoxBookPress";
            this.textBoxBookPress.Size = new System.Drawing.Size(239, 37);
            this.textBoxBookPress.TabIndex = 1;
            this.textBoxBookPress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(213, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "ISBN：";
            // 
            // textBoxBookISBN
            // 
            this.textBoxBookISBN.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBookISBN.Location = new System.Drawing.Point(373, 271);
            this.textBoxBookISBN.Name = "textBoxBookISBN";
            this.textBoxBookISBN.Size = new System.Drawing.Size(239, 37);
            this.textBoxBookISBN.TabIndex = 1;
            this.textBoxBookISBN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(213, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "库存：";
            // 
            // textBoxBookStock
            // 
            this.textBoxBookStock.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBookStock.Location = new System.Drawing.Point(373, 332);
            this.textBoxBookStock.Name = "textBoxBookStock";
            this.textBoxBookStock.Size = new System.Drawing.Size(239, 37);
            this.textBoxBookStock.TabIndex = 1;
            this.textBoxBookStock.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(148, 460);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(194, 78);
            this.buttonAddBook.TabIndex = 2;
            this.buttonAddBook.Text = "添加图书";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonCancalAddBook
            // 
            this.buttonCancalAddBook.Location = new System.Drawing.Point(606, 460);
            this.buttonCancalAddBook.Name = "buttonCancalAddBook";
            this.buttonCancalAddBook.Size = new System.Drawing.Size(194, 78);
            this.buttonCancalAddBook.TabIndex = 2;
            this.buttonCancalAddBook.Text = "取消";
            this.buttonCancalAddBook.UseVisualStyleBackColor = true;
            this.buttonCancalAddBook.Click += new System.EventHandler(this.buttonCancalAddBook_Click);
            // 
            // FormAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 649);
            this.Controls.Add(this.buttonCancalAddBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.textBoxBookStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBookISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBookPress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBookAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBookTitle);
            this.Controls.Add(this.label1);
            this.Name = "FormAddBook";
            this.Text = "FormAddBook";
            this.Load += new System.EventHandler(this.FormAddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBookTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBookAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBookPress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBookISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBookStock;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonCancalAddBook;
    }
}