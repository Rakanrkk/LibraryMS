using System;
using System.Windows.Forms;

namespace BookManageApp_Access.AdminForms.AdminManageForms
{
    public partial class FormAddAdmin : Form
    {
        public FormAddAdmin()
        {
            InitializeComponent();
        }
        private void buttonCancalAddAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddAdmin_Click(object sender, EventArgs e)
        {
            if (textBoxAdminPsw.Text != "" 
                && textBoxAdminId.Text != "")
            {
                try
                {
                    DAO dao = new DAO();
                    string sql = $"insert into Admin values('{textBoxAdminId.Text}','{textBoxAdminPsw.Text}')";
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
                MessageBox.Show("请输入管理员信息");
            }
            
        }

    }
}
