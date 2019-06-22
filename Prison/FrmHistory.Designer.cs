namespace Prison
{
    partial class FrmHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistory));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pri_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pri_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pri_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pri_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pri_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pri_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pri_ondata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pri_offdata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pri_now = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(27, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 52);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入姓名/ID查找";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 42);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(704, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "查找";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pri_name,
            this.pri_age,
            this.pri_sex,
            this.pri_address,
            this.pri_id,
            this.pri_reason,
            this.pri_ondata,
            this.pri_offdata,
            this.pri_now});
            this.dataGridView1.Location = new System.Drawing.Point(1, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1529, 446);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(790, 12);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(81, 42);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "保存";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(895, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 42);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "添加行";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(998, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 42);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "删除行";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pri_name
            // 
            this.pri_name.DataPropertyName = "pri_name";
            this.pri_name.HeaderText = "姓名";
            this.pri_name.Name = "pri_name";
            // 
            // pri_age
            // 
            this.pri_age.DataPropertyName = "pri_age";
            this.pri_age.HeaderText = "年龄";
            this.pri_age.Name = "pri_age";
            // 
            // pri_sex
            // 
            this.pri_sex.DataPropertyName = "pri_sex";
            this.pri_sex.HeaderText = "性别";
            this.pri_sex.Name = "pri_sex";
            // 
            // pri_address
            // 
            this.pri_address.DataPropertyName = "pri_address";
            this.pri_address.HeaderText = "籍贯";
            this.pri_address.Name = "pri_address";
            // 
            // pri_id
            // 
            this.pri_id.DataPropertyName = "pri_id";
            this.pri_id.HeaderText = "编号";
            this.pri_id.Name = "pri_id";
            // 
            // pri_reason
            // 
            this.pri_reason.DataPropertyName = "pri_reason";
            this.pri_reason.HeaderText = "服刑类型";
            this.pri_reason.Name = "pri_reason";
            this.pri_reason.Width = 120;
            // 
            // pri_ondata
            // 
            this.pri_ondata.DataPropertyName = "pri_ondata";
            this.pri_ondata.HeaderText = "入狱时间";
            this.pri_ondata.Name = "pri_ondata";
            this.pri_ondata.Width = 120;
            // 
            // pri_offdata
            // 
            this.pri_offdata.DataPropertyName = "pri_offdata";
            this.pri_offdata.HeaderText = "出狱时间";
            this.pri_offdata.Name = "pri_offdata";
            this.pri_offdata.Width = 120;
            // 
            // pri_now
            // 
            this.pri_now.DataPropertyName = "pri_now";
            this.pri_now.HeaderText = "现状";
            this.pri_now.Name = "pri_now";
            this.pri_now.Width = 120;
            // 
            // FrmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1542, 672);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FrmHistory";
            this.Text = "查找历史犯人";
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
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn pri_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pri_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn pri_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn pri_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn pri_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pri_reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn pri_ondata;
        private System.Windows.Forms.DataGridViewTextBoxColumn pri_offdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn pri_now;
    }
}