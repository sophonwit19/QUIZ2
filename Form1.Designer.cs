namespace Quiz2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            tbid = new TextBox();
            tbname = new TextBox();
            tbmajor = new TextBox();
            tbgrade = new TextBox();
            cmbAdvisor = new ComboBox();
            AddStudent = new Button();
            groupBox1 = new GroupBox();
            lbmajor = new Label();
            label10 = new Label();
            label8 = new Label();
            lbadvisor = new Label();
            lbgrade = new Label();
            lbname = new Label();
            lbid = new Label();
            label7 = new Label();
            label6 = new Label();
            label9 = new Label();
            button2 = new Button();
            lstStudents = new ListBox();
            colorDialog1 = new ColorDialog();
            label11 = new Label();
            btnShowAdvisorsAndStudents = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 58);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "ID KKU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 101);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "ชื่อ-นามสกุล";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 173);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 2;
            label3.Text = "สาขาที่เรียนอยู่";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 217);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 4;
            label5.Text = "รายชื่ออาจาร์ย";
            // 
            // tbid
            // 
            tbid.Location = new Point(134, 55);
            tbid.Name = "tbid";
            tbid.Size = new Size(125, 27);
            tbid.TabIndex = 5;
            // 
            // tbname
            // 
            tbname.Location = new Point(134, 94);
            tbname.Name = "tbname";
            tbname.Size = new Size(125, 27);
            tbname.TabIndex = 6;
            // 
            // tbmajor
            // 
            tbmajor.Location = new Point(134, 173);
            tbmajor.Name = "tbmajor";
            tbmajor.Size = new Size(125, 27);
            tbmajor.TabIndex = 7;
            // 
            // tbgrade
            // 
            tbgrade.Location = new Point(134, 137);
            tbgrade.Name = "tbgrade";
            tbgrade.Size = new Size(125, 27);
            tbgrade.TabIndex = 8;
            // 
            // cmbAdvisor
            // 
            cmbAdvisor.FormattingEnabled = true;
            cmbAdvisor.Location = new Point(134, 209);
            cmbAdvisor.Name = "cmbAdvisor";
            cmbAdvisor.Size = new Size(151, 28);
            cmbAdvisor.TabIndex = 9;
            // 
            // AddStudent
            // 
            AddStudent.Location = new Point(134, 265);
            AddStudent.Name = "AddStudent";
            AddStudent.Size = new Size(94, 29);
            AddStudent.TabIndex = 10;
            AddStudent.Text = "NewStd";
            AddStudent.UseVisualStyleBackColor = true;
            AddStudent.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbmajor);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lbadvisor);
            groupBox1.Controls.Add(lbgrade);
            groupBox1.Controls.Add(lbname);
            groupBox1.Controls.Add(lbid);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(557, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 194);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูล";
            // 
            // lbmajor
            // 
            lbmajor.AutoSize = true;
            lbmajor.Location = new Point(167, 161);
            lbmajor.Name = "lbmajor";
            lbmajor.Size = new Size(58, 20);
            lbmajor.TabIndex = 9;
            lbmajor.Text = "label15";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 128);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 4;
            label10.Text = "อาจาร์ยที่ปรึกษา";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 161);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 2;
            label8.Text = "สาขา";
            // 
            // lbadvisor
            // 
            lbadvisor.AutoSize = true;
            lbadvisor.Location = new Point(167, 128);
            lbadvisor.Name = "lbadvisor";
            lbadvisor.Size = new Size(58, 20);
            lbadvisor.TabIndex = 8;
            lbadvisor.Text = "label14";
            // 
            // lbgrade
            // 
            lbgrade.AutoSize = true;
            lbgrade.Location = new Point(167, 97);
            lbgrade.Name = "lbgrade";
            lbgrade.Size = new Size(58, 20);
            lbgrade.TabIndex = 7;
            lbgrade.Text = "label13";
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Location = new Point(167, 66);
            lbname.Name = "lbname";
            lbname.Size = new Size(58, 20);
            lbname.TabIndex = 6;
            lbname.Text = "label12";
            // 
            // lbid
            // 
            lbid.AutoSize = true;
            lbid.Location = new Point(167, 35);
            lbid.Name = "lbid";
            lbid.Size = new Size(58, 20);
            lbid.TabIndex = 5;
            lbid.Text = "label11";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 66);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 1;
            label7.Text = "ชื่อ-นามสกุล";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 35);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 0;
            label6.Text = "รหัสนักศึกษา";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(47, 97);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 3;
            label9.Text = "เกรด";
            // 
            // button2
            // 
            button2.Location = new Point(641, 263);
            button2.Name = "button2";
            button2.Size = new Size(158, 31);
            button2.TabIndex = 12;
            button2.Text = "แสดงคะแนน Max-min";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.Location = new Point(6, 26);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(180, 164);
            lstStudents.TabIndex = 13;
            lstStudents.SelectedIndexChanged += lstStudents_SelectedIndexChanged_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(71, 140);
            label11.Name = "label11";
            label11.Size = new Size(37, 20);
            label11.TabIndex = 14;
            label11.Text = "เกรด";
            // 
            // btnShowAdvisorsAndStudents
            // 
            btnShowAdvisorsAndStudents.Location = new Point(333, 265);
            btnShowAdvisorsAndStudents.Name = "btnShowAdvisorsAndStudents";
            btnShowAdvisorsAndStudents.Size = new Size(158, 29);
            btnShowAdvisorsAndStudents.TabIndex = 16;
            btnShowAdvisorsAndStudents.Text = "แสดงรายชื่ออาจาร์ย";
            btnShowAdvisorsAndStudents.UseVisualStyleBackColor = true;
            btnShowAdvisorsAndStudents.Click += btnShowAdvisorsAndStudents_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstStudents);
            groupBox2.Location = new Point(318, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(192, 194);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "บันทึกข้อมูลแล้ว";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 545);
            Controls.Add(groupBox2);
            Controls.Add(btnShowAdvisorsAndStudents);
            Controls.Add(label11);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(AddStudent);
            Controls.Add(cmbAdvisor);
            Controls.Add(tbgrade);
            Controls.Add(tbmajor);
            Controls.Add(tbname);
            Controls.Add(tbid);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox tbid;
        private TextBox tbname;
        private TextBox tbmajor;
        private TextBox tbgrade;
        private ComboBox cmbAdvisor;
        private Button AddStudent;
        private GroupBox groupBox1;
        private Label lbmajor;
        private Label lbadvisor;
        private Label lbname;
        private Label lbid;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button button2;
        private ListBox lstStudents;
        private Label lbgrade;
        private ColorDialog colorDialog1;
        private Label label11;
        private Button btnShowAdvisorsAndStudents;
        private GroupBox groupBox2;
    }
}
