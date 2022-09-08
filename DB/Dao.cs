using System.Data.OleDb;
using System.Text;
using System.Data;

namespace BookManageApp_Access
{
    internal class DAO
    {
        OleDbConnection conn;
        public OleDbConnection connect()//链接数据库
        {
            string str = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = .\DB\Database1.accdb";
            conn = new OleDbConnection(str);
            conn.Open();
            return conn;
        }

        public OleDbCommand command(string sql)//该函数传入sql命令
        {
            OleDbCommand cmd = new OleDbCommand(sql, connect());
            return cmd;
        }
        public int Execute(string sql)//该函数对数据库进行数据操作
        {
            return command(sql).ExecuteNonQuery();
        }
        public OleDbDataReader read(string sql)//该函数用于读取数据库数据
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()//关闭数据库链接
        {
            conn.Close();
        }
    }
}
