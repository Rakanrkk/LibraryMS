using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BookManageApp_Access.StuForms;
using BookManageApp_Access;

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
            while(dc.Read())
            {
                dataGridViewBook.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        private void dataGridViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBookMS_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

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
            string id = dataGridViewBook.SelectedRows[0].Cells[0].Value.ToString();
            int stock = int.Parse(dataGridViewBook.SelectedRows[0].Cells[4].Value.ToString());
            int num = int.Parse(dao.read($"select * from stu where id='{UserData.UID}'")[3].ToString());
            if (stock>0)
            {
                if (num>0)
                {
                    sql = $"insert into borrow values('{id}','{DateTime.Now.ToString()}','{UserData.UID},'{0}')";
                    dao.Execute(sql);
                    sql = $"update book set stock=stock-1 where isbn='{id}'";
                    dao.Execute(sql);
                    sql = $"update stu set num=num+1 where isbn='{id}'";
                }
                else
                {
                    MessageBox.Show("你已经借满五本了");
                }
            }
            else
            {
                MessageBox.Show("库存不足");
            }
        }
    }
}
