using System;
using System.Windows.Forms;

namespace BookManageApp_Access.AdminForms.StuManageForms
{
    public partial class FormAddStu : Form
    {
        public FormAddStu()
        {
            InitializeComponent();
        }
        private void buttonCancalAddStu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddStu_Click(object sender, EventArgs e)
        {
            if (textBoxStuPsw.Text != "" 
                && textBoxStuId.Text != "")
            {
                try
                {
                    Dao dao = new Dao();
                    string sql = $"insert into Stu values('{textBoxStuId.Text}','{textBoxStuPsw.Text}')";
                    dao.Execute(sql);
                    MessageBox.Show("success");
                    dao.DaoClose();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("fail");
                }
            }
            else
            {
                MessageBox.Show("请输入学生信息");
            }
            
        }

    }
}
