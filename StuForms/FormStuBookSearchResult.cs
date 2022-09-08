using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookManageApp_Access;

namespace BookManageApp_Access.StuForms
{
    public partial class FormStuBookSearchResult : Form
    {
        private IDataReader dc;
        public void ShowResults()
        {
            dataGridViewResultBook.Rows.Clear();
            while (dc.Read())
            {
                dataGridViewResultBook.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
        }
        public FormStuBookSearchResult()
        {
            InitializeComponent();
        }

        public FormStuBookSearchResult(ref IDataReader result)
        {
            InitializeComponent();
            dc = result;
            ShowResults();


        }
        private void FormBookSearchResult_Load(object sender, EventArgs e)
        {

        }


        private void dataGridViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBorrowBook_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            string sql;
            string isbn = dataGridViewResultBook.SelectedRows[0].Cells[0].Value.ToString();
            int stock = int.Parse(dataGridViewResultBook.SelectedRows[0].Cells[4].Value.ToString());
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
            ShowResults();
        }
    }
}
