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
            Dao dao = new Dao();
            string sql = @"SELECT borrow.isbn, book.title, book.author, book.press, borrow.time, borrow.if_returned FROM (stu INNER JOIN borrow ON stu.id = borrow.uid) INNER JOIN book ON borrow.isbn = book.isbn ORDER BY borrow.time;";
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

        }
    }

    



}
