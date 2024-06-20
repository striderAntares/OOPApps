namespace _20_OOPEnumPersonnel
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(386, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(386, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 28);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(386, 159);
            button1.Name = "button1";
            button1.Size = new Size(204, 47);
            button1.TabIndex = 2;
            button1.Text = "Save Personnel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(40, 50);
            label1.Name = "label1";
            label1.Size = new Size(340, 47);
            label1.TabIndex = 3;
            label1.Text = "Enter Name and Surname of the new personnel:";
            // 
            // label2
            // 
            label2.Location = new Point(40, 107);
            label2.Name = "label2";
            label2.Size = new Size(340, 47);
            label2.TabIndex = 3;
            label2.Text = "Select the unit of the new personnel:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 254);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "enumspreciousenums";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}
