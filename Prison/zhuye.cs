using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prison
{
    public partial class zhuye : Form
    {
        public Login n1 = null;
        public FrmSearch fsc = new FrmSearch();
        public FrmAdd fsa = new FrmAdd();
        public FrmPoliceman fgs = new FrmPoliceman();
        public FrmTime pf = new FrmTime();
        public FrmRoom fr = new FrmRoom();
        public Location la = new Location();
        public zhuye()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            fsc.z = this;
            this.Hide();
            fsc.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            n1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            fsa.z = this;
            this.Hide();
            fsa.Show();
        }

      
        private void label4_Click(object sender, EventArgs e)
        {
            fgs.z = this;
            this.Hide();
            fgs.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            pf.z = this;
            this.Hide();
            pf.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            fr.z = this;
            this.Hide();
            fr.Show();
        }
        private void About_Click(object sender, EventArgs e)
        {
            AboutBox_AvoutUs ab = new AboutBox_AvoutUs();
            ab.ShowDialog();
        }

        private void AccountManage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            la.z = this;
            this.Hide();
            la.Show();
        }
    }
}
