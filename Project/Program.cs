using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookManageApp_Access.AdminForms.BookManageForms;
using BookManageApp_Access.AdminForms.AdminManageForms;
using BookManageApp_Access.StuForms;

namespace BookManageApp_Access
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new FormBookMS());
            //Application.Run(new FormStuMain());
        }
    }
}
