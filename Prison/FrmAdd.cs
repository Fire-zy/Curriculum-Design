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
    public partial class FrmAdd : Form
    {
        public zhuye z = null;
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            z.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //拼接T-SQL语句
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ZY\source\repos\Prison\Prison\PrisonDataBase.mdf;Integrated Security=True;MultipleActiveResultSets=true";
            //执行SQL语句
            SqlConnection sqlCnt = new SqlConnection(connstr);//实例化连接数据库的类的对象
            sqlCnt.Open();//调用对象中打开数据库的方法
            string name = textBox1.Text.ToString();
            string age = textBox2.Text.ToString();
            string sex = textBox3.Text.ToString();
            string ondata = dateTimePicker1.Text.ToString();
            string address = provience.SelectedItem.ToString()+comboBox1.SelectedItem.ToString()+comboBox2.SelectedItem.ToString();
            string reason = textBox7.Text.ToString();

            string id = textBox6.Text.ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Text = "";
            provience.SelectedItem = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //拼接T-SQL语句
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ZY\source\repos\Prison\Prison\PrisonDataBase.mdf;Integrated Security=True";
            //执行SQL语句
            SqlConnection sqlCnt = new SqlConnection(connstr);//实例化连接数据库的类的对象
            sqlCnt.Open();//调用对象中打开数据库的方法
            string name = textBox1.Text.ToString();
            string age = textBox2.Text.ToString();
            string sex = textBox3.Text.ToString();
            string ondata = dateTimePicker1.Text.ToString();
            string address = provience.SelectedItem.ToString();
            string id = textBox6.Text.ToString();
            string reason = textBox7.Text.ToString();

            string sql = "delete from PrisonAdd where pri_name='" + name + "'";
            SqlCommand command = new SqlCommand(sql, sqlCnt);

            try
            {
                int rc = command.ExecuteNonQuery();
                if (rc == 1)
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlCnt.Close();
        }


        private void provience_SelectedIndexChanged(object sender, EventArgs e)
        {
            int s = (int)provience.SelectedIndex;
            comboBox1.Items.Clear();
            switch (s)
            {
                case 0:
                    comboBox1.Items.Add("巴南区");
                    comboBox1.Items.Add("北碚区");
                    comboBox1.Items.Add("渝北区");
                    comboBox1.Items.Add("涪陵区");
                    comboBox1.Items.Add("长寿区");
                    comboBox1.Items.Add("秀山土家族苗族自治县");
                    comboBox1.Items.Add("酉阳土家族苗族自治县");
                    comboBox1.Items.Add("彭水苗族土家族自治县");
                    comboBox1.Items.Add("垫江县");
                    break;
                case 1:
                    comboBox1.Items.Add("遂宁市");
                    comboBox1.Items.Add("成都市");
                    comboBox1.Items.Add("德阳市");
                    comboBox1.Items.Add("攀枝花市");
                    comboBox1.Items.Add("乐山市");
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = (int)comboBox1.SelectedIndex;
            comboBox2.Items.Clear();
            if(comboBox1.SelectedItem.ToString() == "巴南区")
            {
                comboBox2.Items.Add("");
            }
            else if (comboBox1.SelectedItem.ToString() == "遂宁市")
            {
                comboBox2.Items.Add("船山区");
                comboBox2.Items.Add("安居区");
                comboBox2.Items.Add("射洪县");
                comboBox2.Items.Add("蓬溪县");
                comboBox2.Items.Add("大英县");
            }else if (comboBox1.SelectedItem.ToString() == "成都市")
            {
                comboBox2.Items.Add("蒲江县");
                comboBox2.Items.Add("大邑县");
                comboBox2.Items.Add("金堂县");
                comboBox2.Items.Add("银郫县");
                comboBox2.Items.Add("崇庆县");
            }
              
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
