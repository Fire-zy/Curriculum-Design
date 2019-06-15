namespace Prison
{
    partial class FrmPoliceman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPoliceman));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.pol_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pol_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pol_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pol_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pol_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pol_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pol_room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(23, 632);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 52);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入姓名/ID查找";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 42);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(739, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "查找";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pol_name,
            this.pol_age,
            this.pol_sex,
            this.pol_address,
            this.pol_id,
            this.pol_number,
            this.pol_room});
            this.dataGridView1.Location = new System.Drawing.Point(23, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1461, 501);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(947, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "添加";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1105, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 42);
            this.button4.TabIndex = 8;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(860, 12);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(81, 42);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "保存";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // pol_name
            // 
            this.pol_name.DataPropertyName = "pol_name";
            this.pol_name.HeaderText = "姓名";
            this.pol_name.Name = "pol_name";
            this.pol_name.Width = 120;
            // 
            // pol_age
            // 
            this.pol_age.DataPropertyName = "pol_age";
            this.pol_age.HeaderText = "年龄";
            this.pol_age.Name = "pol_age";
            this.pol_age.Width = 120;
            // 
            // pol_sex
            // 
            this.pol_sex.DataPropertyName = "pol_sex";
            this.pol_sex.HeaderText = "性别";
            this.pol_sex.Name = "pol_sex";
            this.pol_sex.Width = 120;
            // 
            // pol_address
            // 
            this.pol_address.DataPropertyName = "pol_address";
            this.pol_address.HeaderText = "籍贯";
            this.pol_address.Name = "pol_address";
            this.pol_address.Width = 120;
            // 
            // pol_id
            // 
            this.pol_id.DataPropertyName = "pol_id";
            this.pol_id.HeaderText = "编号";
            this.pol_id.Name = "pol_id";
            this.pol_id.Width = 120;
            // 
            // pol_number
            // 
            this.pol_number.DataPropertyName = "pol_number";
            this.pol_number.HeaderText = "电话";
            this.pol_number.Name = "pol_number";
            this.pol_number.Width = 120;
            // 
            // pol_room
            // 
            this.pol_room.DataPropertyName = "pol_room";
            this.pol_room.HeaderText = "负责房间";
            this.pol_room.Name = "pol_room";
            this.pol_room.Width = 120;
            // 
            // FrmPoliceman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1496, 696);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FrmPoliceman";
            this.Text = "FrmPoliceman";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridViewTextBoxColumn pol_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pol_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn pol_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn pol_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn pol_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pol_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn pol_room;
    }
}