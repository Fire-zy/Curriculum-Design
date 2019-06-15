using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prison
{
    public partial class Login : Form
    {
        public zhuye z = new zhuye();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //拼接T-SQL语句
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ZY\source\repos\Prison\Prison\PrisonDataBase.mdf;Integrated Security=True;MultipleActiveResultSets=true";
            //执行SQL语句
            SqlConnection sqlCnt = new SqlConnection(connstr);//实例化连接数据库的类的对象
            sqlCnt.Open();//调用对象中打开数据库的方法
            string name = textBox1.Text.ToString();//获得输入的内容
            string pw = textBox2.Text.ToString();
            string sql = "select * from dbo.[Login] where [User] ='" + name + "' and [Pw]='" + pw + "'";

            SqlCommand command = new SqlCommand(sql, sqlCnt);//实例化SqlCommand对象
            SqlDataReader sr = command.ExecuteReader();//执行SQL语句，并接收返回的受影响行数
            if (sr.Read())//如果能前进到下一条记录，就说明有值
            {
                z.n1 = this;
                this.Hide();
                z.Show();
            }
            else
            {
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pw))
                {
                    MessageBox.Show("用户名和密码不能为空");
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                }
            }
            sqlCnt.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }
    }
}
