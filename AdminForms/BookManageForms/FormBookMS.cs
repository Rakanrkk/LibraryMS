using System;
using System.Data;
using System.Windows.Forms;

namespace BookManageApp_Access
{
    public partial class FormBookMS : Form
    {
        public FormBookMS()
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

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("确认删除吗", "提示", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    
                    string isbn = dataGridViewBook.SelectedRows[0].Cells[0].Value.ToString();
                    string sql = $"delete from book where isbn ='{isbn}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
                        ShowBooks();
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

        private void FormBookMS_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            FormAddBook formAddBook = new FormAddBook();
            formAddBook.ShowDialog();
            ShowBooks();
        }

        private void buttonEditBook_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridViewBook.SelectedRows[0].Cells[0].Value.ToString();
                string title=dataGridViewBook.SelectedRows[0].Cells[1].Value.ToString();
                string author=dataGridViewBook.SelectedRows[0].Cells[2].Value.ToString();
                string press=dataGridViewBook.SelectedRows[0].Cells[3].Value.ToString();
                string stock=dataGridViewBook.SelectedRows[0].Cells[4].Value.ToString();
                FormEditBook formEditBook = new FormEditBook(id,title,author,press,stock);
                formEditBook.ShowDialog();
                ShowBooks();
            }
            catch
            {
                MessageBox.Show("请选中要修改的书籍");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
