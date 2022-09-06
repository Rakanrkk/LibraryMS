using System;
using System.Windows.Forms;

namespace BookManageApp_Access.AdminForms.BookManageForms
{
    public partial class FormAddBook : Form
    {
        public FormAddBook()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancalAddBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (textBoxBookAuthor.Text != "" 
                && textBoxBookISBN.Text != "" 
                && textBoxBookPress.Text != "" 
                && textBoxBookStock.Text != "" 
                && textBoxBookTitle.Text != "")
            {
                try
                {
                    Dao dao = new Dao();
                    string sql = $"insert into book values('{textBoxBookISBN.Text}','{textBoxBookTitle.Text}','{textBoxBookAuthor.Text}','{textBoxBookPress.Text}',{textBoxBookStock.Text})";
                    dao.Execute(sql);
                    MessageBox.Show("success");
                    dao.DaoClose();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("fail");
                }



                
            }
            else
            {
                MessageBox.Show("请输入书籍信息");
            }
            
        }

        private void FormAddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
