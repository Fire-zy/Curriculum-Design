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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            //拼接T-SQL语句
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ZY\source\repos\Prison\Prison\PrisonDataBase.mdf;Integrated Security=True;MultipleActiveResultSets=true";
            //执行SQL语句
            SqlConnection sqlCnt = new SqlConnection(connstr);//实例化连接数据库的类的对象
            sqlCnt.Open();//调用对象中打开数据库的方法
            string name = textBox1.Text.ToString();
            string age = textBox2.Text.ToString();
            string sex = textBox3.Text.ToString();
            string ondata = textBox7.Text.ToString();
            string address = textBox4.Text.ToString();
            string id = textBox5.Text.ToString();
            string reason = textBox6.Text.ToString();

            string sql = "Update PrisonAdd set pri_name='"+name+"',pri_age='"+age+"',pri_sex='"+sex+"',pri_ondata='"+ondata+"'," +
                "pri_address='"+ address + "',pri_reason='"+reason+"' where pri_id='"+id+"'";
             SqlCommand command = new SqlCommand(sql, sqlCnt);
            try
            {
                int rc = command.ExecuteNonQuery();
                if (rc == 1)
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //sqlCnt.Close();
        }
        }

        
    
}
