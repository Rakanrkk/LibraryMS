using System;
using System.Data;
using System.Windows.Forms;
using BookManageApp_Access.AdminForms.StuManageForms;

namespace BookManageApp_Access.AdminForms.StuManageForms
{
    public partial class FormStuMS : Form
    {
        public FormStuMS()
        {
            InitializeComponent();
            ShowStus();
        }
        public void ShowStus()
        {
            dataGridViewStu.Rows.Clear();
            DAO dao = new DAO();
            string sql = "select * from Stu";
            IDataReader dc = dao.read(sql);
            while(dc.Read())
            {
                dataGridViewStu.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        private void buttonDeleteStu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("确认删除吗", "提示", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    
                    string id = dataGridViewStu.SelectedRows[0].Cells[0].Value.ToString();
                    string sql = $"delete from Stu where id ='{id}'";
                    DAO dao = new DAO();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
                        ShowStus();
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

            
        }

        private void buttonAddStu_Click(object sender, EventArgs e)
        {
            FormAddStu formAddStu = new FormAddStu();
            formAddStu.ShowDialog();
            ShowStus();
        }

        private void buttonEditStu_Click(object sender, EventArgs e)
        {  
            string id = dataGridViewStu.SelectedRows[0].Cells[0].Value.ToString();
            string psw=dataGridViewStu.SelectedRows[0].Cells[1].Value.ToString();
            string name=dataGridViewStu.SelectedRows[0].Cells[2].Value.ToString();
            FormEditStu formEditStu = new FormEditStu(id,psw,name);
            formEditStu.ShowDialog();
            ShowStus();

        }

        private void buttonSearchId_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            string sql = $"select * from Stu where id='{textBoxSearchId.Text}'";
            IDataReader dc = dao.read(sql);
            FormStuSearchResult formStuSearchResult = new FormStuSearchResult(ref dc);
            formStuSearchResult.ShowDialog();
            ShowStus();
            dc.Close();
            dao.DaoClose();
        }
    }
}
