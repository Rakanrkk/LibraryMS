using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookManageApp_Access.AdminForms.BookManageForms;
using BookManageApp_Access.AdminForms.AdminManageForms;
using BookManageApp_Access.AdminForms.StuManageForms;
namespace BookManageApp_Access
{
    public partial class FormAdminMain : Form
    {
        public FormAdminMain()
        {
            InitializeComponent();
        }

        private void BookManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBookMS formBookMS = new FormBookMS();
            this.Hide();
            formBookMS.ShowDialog();
            this.Show();
        }
        private void AdminManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminMS formAdminMS = new FormAdminMS();
            this.Hide();
            formAdminMS.ShowDialog();
            this.Show();
        }
        private void StuManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStuMS formStuMS = new FormStuMS();
            this.Hide();
            formStuMS.ShowDialog();
            this.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
