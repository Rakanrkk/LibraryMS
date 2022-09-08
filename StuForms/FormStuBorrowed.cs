using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManageApp_Access.StuForms
{
    public partial class FormStuBorrowed : Form
    {
        public FormStuBorrowed()
        {
            InitializeComponent();
            ShowBooksBorrowed();
        }

        private void dataGridViewBookBorrowed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ShowBooksBorrowed()
        {
            dataGridViewBookBorrowed.Rows.Clear();
            DAO dao = new DAO();
            string sql = "SELECT borrow.isbn, book.title, book.author, book.press, borrow.time, borrow.if_returned FROM (stu INNER JOIN borrow ON stu.id = borrow.uid) INNER JOIN book ON borrow.isbn = book.isbn ORDER BY borrow.time;";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridViewBookBorrowed.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            string if_returned = dataGridViewBookBorrowed.SelectedRows[0].Cells[5].Value.ToString();
            if(if_returned=="no")
            {
                string isbn = dataGridViewBookBorrowed.SelectedRows[0].Cells[0].Value.ToString();
                string time = dataGridViewBookBorrowed.SelectedRows[0].Cells[4].Value.ToString();
                DAO dao = new DAO();
                string sql = $"update book set stock=stock+1 where isbn='{isbn}'";
                dao.Execute(sql);
                sql = $"update borrow set if_returned='{"yes"}' where time='{time}'";
                dao.Execute(sql);
                sql = $"insert into return values('{isbn}','{DateTime.Now.ToString()}','{UserData.UID}')";
                dao.Execute(sql);
                dao.DaoClose();
            }
            else
            {
                MessageBox.Show("这本书已经归还");
            }
            ShowBooksBorrowed();

        }
    }

    



}
