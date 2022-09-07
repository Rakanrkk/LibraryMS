using System;
using System.Data;
using System.Windows.Forms;

namespace BookManageApp_Access.StuForms
{
    public partial class FormStuMain : Form
    {
        public FormStuMain()
        {
            InitializeComponent();
            ShowBooks();
        }
        public void ShowBooks()
        {
            dataGridViewBook.Rows.Clear();
            Dao dao = new Dao();
            string sql = "select * from book";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridViewBook.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        private void buttonSearchISBN_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = $"select * from book where isbn='{textBoxSearchISBN.Text}'";
            IDataReader dc = dao.read(sql);
            FormStuBookSearchResult formStuBookSearchResult = new FormStuBookSearchResult(ref dc);
            formStuBookSearchResult.ShowDialog();
            ShowBooks();
            dc.Close();
            dao.DaoClose();
        }


        private void buttonSearchTitle_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = $"select * from book where title like '%{textBoxSearchTitle.Text}%'";
            IDataReader dc = dao.read(sql);
            FormStuBookSearchResult formBookSearchResult = new FormStuBookSearchResult(ref dc);
            formBookSearchResult.ShowDialog();
            ShowBooks();
            dc.Close();
            dao.DaoClose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBorrowBook_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql;
            string isbn = dataGridViewBook.SelectedRows[0].Cells[0].Value.ToString();
            int stock = int.Parse(dataGridViewBook.SelectedRows[0].Cells[4].Value.ToString());
            string no = "no";
            if (stock > 0)
            {
                sql = $"insert into borrow values('{isbn}','{DateTime.Now.ToString()}','{UserData.UID}','{no}')";
                dao.Execute(sql);
                sql = $"update book set stock=stock-1 where isbn='{isbn}'";
                dao.Execute(sql);
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("库存不足");
                dao.read("select * from book");//请勿删除此行，否则报错
            }
            dao.DaoClose();
            ShowBooks();
        }

        private void buttonCheckBorrowed_Click(object sender, EventArgs e)
        {
            FormStuBorrowed formStuBorrowed = new FormStuBorrowed();
            formStuBorrowed.ShowDialog();
        }
    }
}
