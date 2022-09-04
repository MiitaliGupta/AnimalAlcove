namespace AnimalAlcove
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adoption";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(40, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 500);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(265, 628);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 46);
            this.button3.TabIndex = 11;
            this.button3.Text = "Adopt";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(43, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 221);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.LightGray;
            this.listBox2.Font = new System.Drawing.Font("GeoSlab703 MdCn BT", 12F, System.Drawing.FontStyle.Bold);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(281, 66);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(149, 124);
            this.listBox2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(207, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Choose animals you want to adopt";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(207, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightGray;
            this.listBox1.Font = new System.Drawing.Font("GeoSlab703 MdCn BT", 12F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "Dogs",
            "Cats",
            "Rabbits",
            "Guinea Pigs",
            "Hamsters"});
            this.listBox1.Location = new System.Drawing.Point(27, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(149, 124);
            this.listBox1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.listBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(43, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 233);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.LightGray;
            this.listBox3.Font = new System.Drawing.Font("GeoSlab703 MdCn BT", 12F, System.Drawing.FontStyle.Bold);
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 24;
            this.listBox3.Location = new System.Drawing.Point(25, 106);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(405, 100);
            this.listBox3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Breeds Available";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("GeoSlab703 MdCn BT", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(405, 32);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 699);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}