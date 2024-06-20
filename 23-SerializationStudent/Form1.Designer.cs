namespace _23_SerializationStudent
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
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAverages = new TextBox();
            txtMajor = new TextBox();
            txtMobileNumber = new TextBox();
            txteMail = new TextBox();
            txtNameSurname = new TextBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAverages);
            groupBox1.Controls.Add(txtMajor);
            groupBox1.Controls.Add(txtMobileNumber);
            groupBox1.Controls.Add(txteMail);
            groupBox1.Controls.Add(txtNameSurname);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 310);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student info";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(165, 87);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 271);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 2;
            label6.Text = "Averages:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 229);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 2;
            label5.Text = "Major:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 189);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 2;
            label4.Text = "Mobile number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 138);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "E-mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 87);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Birth date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 2;
            label1.Text = "Name Surname:";
            // 
            // txtAverages
            // 
            txtAverages.Location = new Point(165, 271);
            txtAverages.Name = "txtAverages";
            txtAverages.Size = new Size(266, 27);
            txtAverages.TabIndex = 0;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(165, 226);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(266, 27);
            txtMajor.TabIndex = 0;
            // 
            // txtMobileNumber
            // 
            txtMobileNumber.Location = new Point(165, 182);
            txtMobileNumber.Name = "txtMobileNumber";
            txtMobileNumber.Size = new Size(266, 27);
            txtMobileNumber.TabIndex = 0;
            // 
            // txteMail
            // 
            txteMail.Location = new Point(165, 135);
            txteMail.Name = "txteMail";
            txteMail.Size = new Size(266, 27);
            txteMail.TabIndex = 0;
            // 
            // txtNameSurname
            // 
            txtNameSurname.Location = new Point(165, 41);
            txtNameSurname.Name = "txtNameSurname";
            txtNameSurname.Size = new Size(266, 27);
            txtNameSurname.TabIndex = 0;
            // 
            // label7
            // 
            label7.Location = new Point(18, 325);
            label7.Name = "label7";
            label7.Size = new Size(425, 25);
            label7.TabIndex = 2;
            label7.Text = "Generated ID:";
            // 
            // button1
            // 
            button1.Location = new Point(31, 363);
            button1.Name = "button1";
            button1.Size = new Size(166, 54);
            button1.TabIndex = 3;
            button1.Text = "Serialize";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(277, 363);
            button2.Name = "button2";
            button2.Size = new Size(166, 54);
            button2.TabIndex = 3;
            button2.Text = "Deserialize";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Location = new Point(18, 429);
            label8.Name = "label8";
            label8.Size = new Size(425, 25);
            label8.TabIndex = 2;
            label8.Text = "Status:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 497);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAverages;
        private TextBox txtMajor;
        private TextBox txtMobileNumber;
        private TextBox txteMail;
        private TextBox txtNameSurname;
        private Label label8;
        private DateTimePicker dateTimePicker1;
    }
}
