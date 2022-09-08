using System;
using System.Data;
using System.Windows.Forms;
using BookManageApp_Access.AdminForms.AdminManageForms;

namespace BookManageApp_Access.AdminForms.AdminManageForms
{
    public partial class FormAdminMS : Form
    {
        public FormAdminMS()
        {
            InitializeComponent();
            ShowAdmins();
        }
        public void ShowAdmins()
        {
            dataGridViewAdmin.Rows.Clear();
            DAO dao = new DAO();
            string sql = "select * from Admin";
            IDataReader dc = dao.read(sql);
            while(dc.Read())
            {
                dataGridViewAdmin.Rows.Add(dc[0].ToString(), dc[1].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        private void dataGridViewAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDeleteAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("确认删除吗", "提示", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    
                    string id = dataGridViewAdmin.SelectedRows[0].Cells[0].Value.ToString();
                    string sql = $"delete from Admin where id ='{id}'";
                    DAO dao = new DAO();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
                        ShowAdmins();
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
                MessageBox.Show("请先选中要删除的管理");
            }

            
        }

        private void FormAdminMS_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddAdmin_Click(object sender, EventArgs e)
        {
            FormAddAdmin formAddAdmin = new FormAddAdmin();
            formAddAdmin.ShowDialog();
            ShowAdmins();
        }

        private void buttonEditAdmin_Click(object sender, EventArgs e)
        {
            //try
            {
                string id = dataGridViewAdmin.SelectedRows[0].Cells[0].Value.ToString();
                string psw=dataGridViewAdmin.SelectedRows[0].Cells[1].Value.ToString();
                FormEditAdmin formEditAdmin = new FormEditAdmin(id,psw);
                formEditAdmin.ShowDialog();
                ShowAdmins();
            }
            /*catch
            {
                MessageBox.Show("请选中要修改的书籍");

            }*/
        }

        private void buttonSearchId_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            string sql = $"select * from Admin where id='{textBoxSearchId.Text}'";
            IDataReader dc = dao.read(sql);
            FormAdminSearchResult formAdminSearchResult = new FormAdminSearchResult(ref dc);
            formAdminSearchResult.ShowDialog();
            ShowAdmins();
            dc.Close();
            dao.DaoClose();
        }
    }
}
