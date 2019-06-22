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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;    //返回结果为Cancel
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
            string reason = textBox6.Text.ToString();

            string id = textBox5.Text.ToString();
            string strSQL = "select * from PrisonAdd where pri_id='" + id + "'";
            SqlCommand comm = new SqlCommand(strSQL, sqlCnt);
            SqlDataReader dr = comm.ExecuteReader();
            bool flag = dr.Read();

            if (name == "" && age == "" && sex == "" && ondata == "" && address == "" && id == "" && reason == "")
            {
                MessageBox.Show("输入信息不能为空");
            }
            else
            {
                if (flag)
                {
                    MessageBox.Show("输入的编号已存在，请重新输入");
                }
                string sql = "insert into PrisonAdd(pri_name,pri_age,pri_sex,pri_ondata,pri_address,pri_id,pri_reason) values(N'" + name + "',N'" + age + "',N'" + sex + "',N'" + ondata + "',N'" + address + "',N'" + id + "',N'" + reason + "')";
                SqlCommand command = new SqlCommand(sql, sqlCnt);
                try
                {
                    int rc = command.ExecuteNonQuery();
                    if (rc == 1)
                    {
                        MessageBox.Show("添加成功");
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                sqlCnt.Close();
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox1.Focus();
        }
    }
}
