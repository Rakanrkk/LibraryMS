using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManageApp_Access.AdminForms.BookManageForms
{
    public partial class FormEditBook : Form
    {
        string key;
        public FormEditBook(string isbn,string title,string author,string press,string stock)
        {
            InitializeComponent();
            textBoxBookISBN.Text = isbn;
            textBoxBookTitle.Text = title;
            textBoxBookAuthor.Text = author;
            textBoxBookPress.Text = press;
            textBoxBookStock.Text = stock;
            key = isbn;
        }

        private void buttonCancalAddBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditBook_Click(object sender, EventArgs e)
        {
            
            if (textBoxBookAuthor.Text != ""
                && textBoxBookISBN.Text != ""
                && textBoxBookPress.Text != ""
                && textBoxBookStock.Text != ""
                && textBoxBookTitle.Text != "")
            {
                DAO dao = new DAO();
                string sql = $"update book set title='{textBoxBookTitle.Text}',author='{textBoxBookAuthor.Text}',press='{textBoxBookPress.Text}',stock={textBoxBookStock.Text} where isbn='{key}'";
                dao.Execute(sql);
                MessageBox.Show("success");
                dao.DaoClose();
                this.Close();
            }
            else
            {
                MessageBox.Show("请输入书籍信息");
            }
        }
    }
}
