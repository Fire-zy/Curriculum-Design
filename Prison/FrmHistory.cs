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
    public partial class FrmHistory : Form
    {
        public zhuye z = null;
        public FrmHistory()
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
            string sql = "select * from dbo.[PrisonHistory] ";//where [pri_name] like N'%" + content + "%'";//加百分号，模糊查询

            //if (string.IsNullOrEmpty(content))
            //    {
            //       MessageBox.Show("查找内容不能为空");
            //    }
            //    else
            //    {
            // MessageBox.Show("输入错入/不存在该用户");
            //执行SQL语句
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlCnt);
            DataSet ds = new DataSet();
            da.Fill(ds, "个人资料");//参数1是DataSet对象，参数2是表名

            //方法一，绑定数据到DataGridView
            //dataGridView1.DataSource = ds;
            //dataGridView1.DataMember = "个人资料";

            //方法二
            dt = ds.Tables["个人资料"];
            dataGridView1.DataSource = dt.DefaultView;
            //}
            //sqlCnt.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                string sql = "";
                string name = dataGridView1.Rows[i].Cells["pri_name"].Value.ToString();
                string age = dataGridView1.Rows[i].Cells["pri_age"].Value.ToString();
                string sex = dataGridView1.Rows[i].Cells["pri_sex"].Value.ToString();
                string ondata = dataGridView1.Rows[i].Cells["pri_ondata"].Value.ToString();
                string offdata = dataGridView1.Rows[i].Cells["pri_offdata"].Value.ToString();
                string address = dataGridView1.Rows[i].Cells["pri_address"].Value.ToString();
                string id = dataGridView1.Rows[i].Cells["pri_id"].Value.ToString();
                string reason = dataGridView1.Rows[i].Cells["pri_reason"].Value.ToString();
                string now = dataGridView1.Rows[i].Cells["pri_now"].Value.ToString();

                if (dataGridView1.Rows[i].HeaderCell.Value == null)
                {
                    sql = "";
                }
                else if (dataGridView1.Rows[i].HeaderCell.Value.ToString() == "N")
                {
                    sql = "insert into PrisonHistory(pri_name,pri_age,pri_sex,pri_address,pri_id,pri_reason,pri_ondata,pri_offdata,pri_now)" +
                        "values(N'" + name + "',N'" + age + "',N'" + sex + "',N'" + address + "',N'" + id + "',N'" + reason + "',N'" + ondata + "',N'" + offdata + "',N'" + now + "')";
                }
                else if (dataGridView1.Rows[i].HeaderCell.Value.ToString() == "D")
                {
                    sql = "delete from PrisonHistory where pri_id='" + id + "'";
                }
                else if (dataGridView1.Rows[i].HeaderCell.Value.ToString() == "U")
                {
                    sql = "update PrisonHistory set pri_name='" + name + "',pri_now='" + now + "',pri_age='" + age + "',pri_offdata='" + offdata + "',pri_sex='" + sex + "'," +
                        "pri_ondata='" + ondata + "',pri_address='" + address + "',pri_reason='" + reason + "' " +
                        "where pri_id='" + id + "'";
                }
                if (sql != "")
                {
                    SqlCommand comm = new SqlCommand(sql, sqlCnt);
                    comm.ExecuteNonQuery();
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dt == null)
            {
                //没有绑定数据时候的添加行
                dataGridView1.Rows.Add();
                int rc = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows[rc].HeaderCell.Value = "N";
            }
            else
            {
                //绑定数据后的添加行
                DataRow dr = dt.NewRow();//创建一个和当前绑定表格具有相同架构的行
                int index = dataGridView1.RowCount == 0 ? 0 : dataGridView1.CurrentRow.Index + 1;
                dt.Rows.InsertAt(dr, index);//把空行加入到指定位置
                dataGridView1.Rows[index].HeaderCell.Value = "N";//在行头显示"n"
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (dataGridView1.Rows[row.Index].HeaderCell.Value == null)
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = "D";
                }
                else if (dataGridView1.Rows[row.Index].HeaderCell.Value.ToString() == "N")
                {
                    dataGridView1.Rows.Remove(row);//参数：选中的行
                }
                else if (dataGridView1.Rows[row.Index].HeaderCell.Value.ToString() == "U")
                {
                    dataGridView1.Rows[row.Index].HeaderCell.Value = "D";
                }
            }
        }
        string sqlOdler;
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //获取修改之前的数据
            sqlOdler = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //获取修改之后的数据
            string sqlNew = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (sqlOdler != sqlNew)
            {
                if (dataGridView1.Rows[e.RowIndex].HeaderCell.Value == null)
                    dataGridView1.Rows[e.RowIndex].HeaderCell.Value = "U";
                else if (dataGridView1.Rows[e.RowIndex].HeaderCell.Value.ToString() == "D")
                    dataGridView1.Rows[e.RowIndex].HeaderCell.Value = "U";
            }
        }

    }
}
