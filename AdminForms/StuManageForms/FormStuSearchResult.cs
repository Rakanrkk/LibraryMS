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

namespace BookManageApp_Access.AdminForms.StuManageForms
{
    public partial class FormStuSearchResult : Form
    {
        private IDataReader dc;
        public void ShowResults()
        {
            dataGridViewResultStu.Rows.Clear();
            while (dc.Read())
            {
                dataGridViewResultStu.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }
        }
        public FormStuSearchResult()
        {
            InitializeComponent();
        }

        public FormStuSearchResult(ref IDataReader result)
        {
            InitializeComponent();
            dc = result;
            ShowResults();


        }
        private void FormStuSearchResult_Load(object sender, EventArgs e)
        {

        }

        private void buttonDeleteStu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("确认删除吗", "提示", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {

                    string id = dataGridViewResultStu.SelectedRows[0].Cells[0].Value.ToString();
                    string sql = $"delete from Stu where id ='{id}'";
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
                MessageBox.Show("请先选中要删除的学生");
            }
            ShowResults();
        }

        private void buttonEditStu_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridViewResultStu.SelectedRows[0].Cells[0].Value.ToString();
                string psw = dataGridViewResultStu.SelectedRows[0].Cells[1].Value.ToString();
                string name = dataGridViewResultStu.SelectedRows[0].Cells[2].Value.ToString();
                FormEditStu formEditStu = new FormEditStu(id, psw, name);
                formEditStu.ShowDialog();
                //ShowResults();
            }
            catch
            {
                MessageBox.Show("请选中要修改的学生信息");

            }
        }

        private void dataGridViewStu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
