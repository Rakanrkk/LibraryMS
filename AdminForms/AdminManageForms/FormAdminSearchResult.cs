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

namespace BookManageApp_Access.AdminForms.AdminManageForms
{
    public partial class FormAdminSearchResult : Form
    {
        private IDataReader dc;
        public void ShowResults()
        {
            dataGridViewResultAdmin.Rows.Clear();
            while (dc.Read())
            {
                dataGridViewResultAdmin.Rows.Add(dc[0].ToString(), dc[1].ToString());
            }
        }

        public FormAdminSearchResult(ref IDataReader result)
        {
            InitializeComponent();
            dc = result;
            ShowResults();


        }
        private void FormAdminSearchResult_Load(object sender, EventArgs e)
        {

        }

        private void buttonDeleteAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("确认删除吗", "提示", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {

                    string id = dataGridViewResultAdmin.SelectedRows[0].Cells[0].Value.ToString();
                    string sql = $"delete from Admin where id ='{id}'";
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
                MessageBox.Show("请先选中要删除的管理员");
            }
        }

        private void buttonEditAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridViewResultAdmin.SelectedRows[0].Cells[0].Value.ToString();
                string psw = dataGridViewResultAdmin.SelectedRows[0].Cells[1].Value.ToString();
                FormEditAdmin formEditAdmin = new FormEditAdmin(id, psw);
                formEditAdmin.ShowDialog();
                //ShowResults();
            }
            catch
            {
                MessageBox.Show("请选中要修改的管理员");

            }
        }

        private void dataGridViewAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
