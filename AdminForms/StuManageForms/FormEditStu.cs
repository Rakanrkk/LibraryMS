using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManageApp_Access.AdminForms.StuManageForms
{
    public partial class FormEditStu : Form
    {
        string key;
        public FormEditStu()
        {
            InitializeComponent();
        }
        public FormEditStu(string id,string psw,string name)
        {
            InitializeComponent();
            textBoxStuId.Text = id;
            textBoxStuPsw.Text = psw;
            textBoxStuName.Text = name;
        }

        private void buttonCancalAddStu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditStu_Click(object sender, EventArgs e)
        {
            
            if (textBoxStuPsw.Text != ""
                && textBoxStuId.Text != ""
                && textBoxStuName.Text!="")
            {
                Dao dao = new Dao();
                string sql = $"update Stu set psw={textBoxStuPsw.Text}, NAME={textBoxStuName.Text} where id='{textBoxStuId.Text}'";
                dao.Execute(sql);
                MessageBox.Show("success");
                dao.DaoClose();
                this.Close();
            }
            else
            {
                MessageBox.Show("请输入学生信息");
            }
        }

        private void FormEditStu_Load(object sender, EventArgs e)
        {

        }

        private void textBoxStuPsw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
