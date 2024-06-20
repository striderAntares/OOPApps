namespace _24_Excercise
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox1 = new GroupBox();
            btnDeleteItem = new Button();
            btnSave = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            txtTRIDNo = new TextBox();
            txtWage = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            mtxtMobileNumber = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            txtSurname = new TextBox();
            txtName = new TextBox();
            txtPersonnelID = new TextBox();
            columnHeader0 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.GridLines = true;
            listView1.Location = new Point(12, 375);
            listView1.Name = "listView1";
            listView1.Size = new Size(1390, 226);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Surname";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Birthdate";
            columnHeader3.Width = 120;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteItem);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(txtTRIDNo);
            groupBox1.Controls.Add(txtWage);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(mtxtMobileNumber);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtPersonnelID);
            groupBox1.Location = new Point(199, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1066, 336);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personnel Info";
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(732, 281);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(133, 39);
            btnDeleteItem.TabIndex = 8;
            btnDeleteItem.Text = "Delete";
            btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(225, 281);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 39);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(697, 237);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 28);
            comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(697, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(697, 77);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 6;
            // 
            // txtTRIDNo
            // 
            txtTRIDNo.Location = new Point(697, 189);
            txtTRIDNo.Name = "txtTRIDNo";
            txtTRIDNo.Size = new Size(250, 27);
            txtTRIDNo.TabIndex = 5;
            // 
            // txtWage
            // 
            txtWage.Location = new Point(697, 147);
            txtWage.Name = "txtWage";
            txtWage.Size = new Size(250, 27);
            txtWage.TabIndex = 5;
            txtWage.KeyPress += txtWage_KeyPress;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(697, 40);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(165, 209);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 4;
            // 
            // mtxtMobileNumber
            // 
            mtxtMobileNumber.Location = new Point(165, 172);
            mtxtMobileNumber.Mask = "(___) ___-__-__";
            mtxtMobileNumber.Name = "mtxtMobileNumber";
            mtxtMobileNumber.Size = new Size(250, 27);
            mtxtMobileNumber.TabIndex = 3;
            mtxtMobileNumber.KeyPress += mtxtMobileNumber_KeyPress;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(165, 139);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // label6
            // 
            label6.Location = new Point(17, 209);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 1;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.Location = new Point(17, 172);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 1;
            label5.Text = "Mobile Number:";
            // 
            // label4
            // 
            label4.Location = new Point(17, 139);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 1;
            label4.Text = "Birthdate:";
            // 
            // label3
            // 
            label3.Location = new Point(17, 106);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 1;
            label3.Text = "Surname:";
            // 
            // label2
            // 
            label2.Location = new Point(17, 73);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label12
            // 
            label12.Location = new Point(487, 240);
            label12.Name = "label12";
            label12.Size = new Size(168, 25);
            label12.TabIndex = 1;
            label12.Text = "Sex:";
            // 
            // label11
            // 
            label11.Location = new Point(487, 189);
            label11.Name = "label11";
            label11.Size = new Size(168, 25);
            label11.TabIndex = 1;
            label11.Text = "Turkish Republic IDNo:";
            // 
            // label10
            // 
            label10.Location = new Point(487, 147);
            label10.Name = "label10";
            label10.Size = new Size(102, 25);
            label10.TabIndex = 1;
            label10.Text = "Wage:";
            // 
            // label9
            // 
            label9.Location = new Point(487, 113);
            label9.Name = "label9";
            label9.Size = new Size(102, 25);
            label9.TabIndex = 1;
            label9.Text = "Title:";
            // 
            // label8
            // 
            label8.Location = new Point(487, 85);
            label8.Name = "label8";
            label8.Size = new Size(102, 25);
            label8.TabIndex = 1;
            label8.Text = "Start date:";
            // 
            // label7
            // 
            label7.Location = new Point(487, 38);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 1;
            label7.Text = "Adress:";
            // 
            // label1
            // 
            label1.Location = new Point(17, 40);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 1;
            label1.Text = "Personnel ID: ";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(165, 106);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(250, 27);
            txtSurname.TabIndex = 0;
            txtSurname.KeyPress += textBox1_KeyPress;
            // 
            // txtName
            // 
            txtName.Location = new Point(165, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 0;
            txtName.KeyPress += textBox1_KeyPress;
            // 
            // txtPersonnelID
            // 
            txtPersonnelID.Enabled = false;
            txtPersonnelID.Location = new Point(165, 40);
            txtPersonnelID.Name = "txtPersonnelID";
            txtPersonnelID.Size = new Size(250, 27);
            txtPersonnelID.TabIndex = 0;
            // 
            // columnHeader0
            // 
            columnHeader0.Text = "Personnel ID";
            columnHeader0.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Mobile Number";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Email";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Address";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Start Date";
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Title";
            columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Wage";
            columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "TR ID No";
            columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Sex";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 707);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSurname;
        private TextBox txtName;
        private TextBox txtPersonnelID;
        private TextBox txtEmail;
        private MaskedTextBox mtxtMobileNumber;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private TextBox txtAddress;
        private Label label7;
        private Label label8;
        private Button btnDeleteItem;
        private Button btnSave;
        private ComboBox comboBox1;
        private TextBox txtWage;
        private Label label10;
        private Label label9;
        private TextBox txtTRIDNo;
        private Label label11;
        private ComboBox comboBox2;
        private Label label12;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader0;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
    }
}
