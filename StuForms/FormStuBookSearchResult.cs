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

namespace BookManageApp_Access.StuForms
{
    public partial class FormStuBookSearchResult : Form
    {
        private IDataReader dc;
        public void ShowResults()
        {
            dataGridViewResultBook.Rows.Clear();
            while (dc.Read())
            {
                dataGridViewResultBook.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
        }
        public FormStuBookSearchResult()
        {
            InitializeComponent();
        }

        public FormStuBookSearchResult(ref IDataReader result)
        {
            InitializeComponent();
            dc = result;
            ShowResults();


        }
        private void FormBookSearchResult_Load(object sender, EventArgs e)
        {

        }


        private void dataGridViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
