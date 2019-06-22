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
using System.Globalization;

namespace Prison
{

    public partial class FrmSearch : Form
    {
        public zhuye z = null;
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            z.Show();
        }
        SqlConnection sqlCnt;
        DataTable dt;
        private void button2_Click(object sender, EventArgs e)
        {
            //拼接T-SQL语句
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ZY\source\repos\Prison\Prison\PrisonDataBase.mdf;Integrated Security=True;MultipleActiveResultSets=true";
            //执行SQL语句
           sqlCnt = new SqlConnection(connstr);//实例化连接数据库的类的对象
            sqlCnt.Open();//调用对象中打开数据库的方法
            string content = textBox1.Text.ToString();//获得输入的内容
            string sql = "select * from dbo.[PrisonAdd] where [pri_name] like N'%" + content + "%'"; //加百分号，模糊查询

            if (string.IsNullOrEmpty(content))
            {
                MessageBox.Show("查找内容不能为空");
            }
            else
            {
                // MessageBox.Show("输入错入/不存在该用户");
                //执行SQL语句
                SqlDataAdapter da = new SqlDataAdapter(sql,sqlCnt);
                DataSet ds = new DataSet();
                da.Fill(ds,"个人资料");//参数1是DataSet对象，参数2是表名
                
                dt = ds.Tables["个人资料"];
                dataGridView1.DataSource = dt.DefaultView;
            }
            // sqlCnt.Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取选中单元格的值
            //textBox1.Text = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            //获取选中的列的名字
            //textBox1.Text= dataGridView1.Columns[e.ColumnIndex].Name;
            //获取选中列的Text属性的值
            //textBox1.Text= dataGridView1.Columns[e.ColumnIndex].HeaderText;

            //给选中的行变色(通常情况下。数据多的时候不建议这样使用)
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(i==e.RowIndex)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                else
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void toolStripSplitButton_Add_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog(this);
        }

        private void toolStripButton_Del_Click(object sender, EventArgs e)
        {         

            DialogResult dr = MessageBox.Show("确实要删除此信息吗?", "删除帐户",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);  //显示对话框
            if (dr == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int r = this.dataGridView1.CurrentRow.Index;
                    string prison = this.dataGridView1.Rows[r].Cells["pri_id"].Value.ToString();
                    //删除 datagridview1 的选中行
                   // this.dataGridView1.Rows.Remove(this.dataGridView1.Rows[r]);
                    this.dataGridView1.Rows.Remove(row);
                    string sql = "";
                    sql = "delete from PrisonAdd where pri_id='" + prison + "'";
                    SqlCommand comm = new SqlCommand(sql, sqlCnt);
                    comm.ExecuteNonQuery();
                }
                
            }
            
        }

        private void toolStripButton_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Modify_Click(object sender, EventArgs e)
        {

            //textBox1.Text= dataGridView1.Rows[a].Cells["pri_id"].Value.ToString();
            Update upd = new Update();
            int a = dataGridView1.CurrentRow.Index;
            upd.textBox1.Text= dataGridView1.Rows[a].Cells["pri_name"].Value.ToString();
            upd.textBox2.Text = dataGridView1.Rows[a].Cells["pri_age"].Value.ToString();
            upd.textBox3.Text = dataGridView1.Rows[a].Cells["pri_sex"].Value.ToString();
            upd.textBox4.Text = dataGridView1.Rows[a].Cells["pri_address"].Value.ToString();
            upd.textBox5.Text = dataGridView1.Rows[a].Cells["pri_id"].Value.ToString();
            upd.textBox6.Text = dataGridView1.Rows[a].Cells["pri_reason"].Value.ToString();
            upd.textBox7.Text = dataGridView1.Rows[a].Cells["pri_ondata"].Value.ToString();
            //string time= dataGridView1.Rows[a].Cells["pri_ondata"].Value.ToString();
            // DateTime dt = DateTime.Parse(time);
            // upd.dateTimePicker1.Text = dt.ToString();
            upd.ShowDialog(this);

        }
    }
}
