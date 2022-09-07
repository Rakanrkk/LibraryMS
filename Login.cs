using System;
using System.Data;
using System.Windows.Forms;
using BookManageApp_Access.StuForms;


namespace BookManageApp_Access
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "" && textBoxPassword.Text != "")
            {
                login();
            }
            else
            {
                MessageBox.Show("请输入账号密码");
            }
        }
        public Boolean login()//登录验证
        {
            if (radioButtonUser.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from stu where id='" + textBoxId.Text + "' and psw='" + textBoxPassword.Text + "'";
                //MessageBox.Show(sql);
                IDataReader dc = dao.read(sql);

                //MessageBox.Show(dc[0].ToString());
                if (dc.Read())
                {
                    MessageBox.Show("登录成功");
                    UserData.UID = textBoxId.Text;
                    FormStuMain formStu = new FormStuMain();
                    this.Hide();
                    formStu.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败");
                    
                }
                dao.DaoClose();

            }
            if (radioButtonAdmin.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from admin where id='" + textBoxId.Text + "' and psw='" + textBoxPassword.Text + "'";
                //MessageBox.Show(sql);
                IDataReader dc = dao.read(sql);

                //MessageBox.Show(dc[0].ToString());
                if (dc.Read())
                {
                    MessageBox.Show("登录成功");
                    FormAdminMain formAdmin = new FormAdminMain();
                    this.Hide();
                    formAdmin.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败");
                    return false;
                }
                dao.DaoClose();
            }
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("注册请联系管理");
        }
    }
}
