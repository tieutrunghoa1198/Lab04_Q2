namespace Lab04_Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.femaleradio = new System.Windows.Forms.RadioButton();
            this.maleradio = new System.Windows.Forms.RadioButton();
            this.nametext = new System.Windows.Forms.TextBox();
            this.idtext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(548, 395);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editbtn);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.refreshbtn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.femaleradio);
            this.groupBox1.Controls.Add(this.maleradio);
            this.groupBox1.Controls.Add(this.nametext);
            this.groupBox1.Controls.Add(this.idtext);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(566, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 395);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Employee";
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(221, 224);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(75, 23);
            this.editbtn.TabIndex = 5;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(123, 224);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(29, 224);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.refreshbtn.TabIndex = 5;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All Positions",
            "Developer",
            "Leader",
            "Tester",
            "Manager"});
            this.comboBox1.Location = new System.Drawing.Point(96, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // femaleradio
            // 
            this.femaleradio.AutoSize = true;
            this.femaleradio.Location = new System.Drawing.Point(153, 110);
            this.femaleradio.Name = "femaleradio";
            this.femaleradio.Size = new System.Drawing.Size(63, 19);
            this.femaleradio.TabIndex = 2;
            this.femaleradio.TabStop = true;
            this.femaleradio.Text = "Female";
            this.femaleradio.UseVisualStyleBackColor = true;
            // 
            // maleradio
            // 
            this.maleradio.AutoSize = true;
            this.maleradio.Location = new System.Drawing.Point(96, 110);
            this.maleradio.Name = "maleradio";
            this.maleradio.Size = new System.Drawing.Size(51, 19);
            this.maleradio.TabIndex = 2;
            this.maleradio.TabStop = true;
            this.maleradio.Text = "Male";
            this.maleradio.UseVisualStyleBackColor = true;
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(96, 76);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(129, 23);
            this.nametext.TabIndex = 1;
            this.nametext.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // idtext
            // 
            this.idtext.Enabled = false;
            this.idtext.Location = new System.Drawing.Point(96, 47);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(129, 23);
            this.idtext.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Position";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "DOB";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sex";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox nametext;
        private TextBox idtext;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private RadioButton femaleradio;
        private RadioButton maleradio;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button editbtn;
        private Button addbtn;
        private Button refreshbtn;
    }
}