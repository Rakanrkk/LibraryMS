using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManageApp_Access.AdminForms.AdminManageForms
{
    public partial class FormEditAdmin : Form
    {
        public FormEditAdmin(string id,string psw)
        {
            InitializeComponent();
            textBoxAdminId.Text = id;
            textBoxAdminPsw.Text = psw;
        }

        private void buttonCancalAddAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditAdmin_Click(object sender, EventArgs e)
        {
            
            if (textBoxAdminPsw.Text != ""
                && textBoxAdminId.Text != "")
            {
                DAO dao = new DAO();
                string sql = $"update Admin set psw={textBoxAdminPsw.Text} where id='{textBoxAdminId.Text}'";
                dao.Execute(sql);
                MessageBox.Show("success");
                dao.DaoClose();
                this.Close();
            }
            else
            {
                MessageBox.Show("请输入管理员信息");
            }
        }

        private void FormEditAdmin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxAdminPsw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
