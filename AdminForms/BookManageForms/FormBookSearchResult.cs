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

namespace BookManageApp_Access.AdminForms.BookManageForms
{
    public partial class FormBookSearchResult : Form
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

        public FormBookSearchResult(ref IDataReader result)
        {
            InitializeComponent();
            dc = result;
            ShowResults();


        }
        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("确认删除吗", "提示", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {

                    string isbn = dataGridViewResultBook.SelectedRows[0].Cells[0].Value.ToString();
                    string sql = $"delete from book where isbn ='{isbn}'";
                    DAO dao = new DAO();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
                        //ShowResults();
                    }
                    else
                    {
                        MessageBox.Show("出现错误！");
                    }
                    dao.DaoClose();
                }

            }
            catch
            {
                MessageBox.Show("请先选中要删除的书目");
            }
        }

        private void buttonEditBook_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridViewResultBook.SelectedRows[0].Cells[0].Value.ToString();
                string title = dataGridViewResultBook.SelectedRows[0].Cells[1].Value.ToString();
                string author = dataGridViewResultBook.SelectedRows[0].Cells[2].Value.ToString();
                string press = dataGridViewResultBook.SelectedRows[0].Cells[3].Value.ToString();
                string stock = dataGridViewResultBook.SelectedRows[0].Cells[4].Value.ToString();
                FormEditBook formEditBook = new FormEditBook(id, title, author, press, stock);
                formEditBook.ShowDialog();
                //ShowResults();
            }
            catch
            {
                MessageBox.Show("请选中要修改的书籍");

            }
        }
    }
}
