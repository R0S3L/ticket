namespace Tickets
{
    partial class Main
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
            dataGridView1 = new DataGridView();
            Namee = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Login = new Label();
            Pass = new Label();
            FIO = new Label();
            Pasport = new Label();
            Birth = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(245, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(825, 374);
            dataGridView1.TabIndex = 0;
            // 
            // Namee
            // 
            Namee.AutoSize = true;
            Namee.Location = new Point(12, 9);
            Namee.Name = "Namee";
            Namee.Size = new Size(38, 15);
            Namee.TabIndex = 1;
            Namee.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(23, 285);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(23, 182);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(23, 234);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Location = new Point(23, 62);
            Login.Name = "Login";
            Login.Size = new Size(41, 15);
            Login.TabIndex = 1;
            Login.Text = "Логин";
            // 
            // Pass
            // 
            Pass.AutoSize = true;
            Pass.Location = new Point(23, 110);
            Pass.Name = "Pass";
            Pass.Size = new Size(49, 15);
            Pass.TabIndex = 1;
            Pass.Text = "Пароль";
            // 
            // FIO
            // 
            FIO.AutoSize = true;
            FIO.Location = new Point(23, 164);
            FIO.Name = "FIO";
            FIO.Size = new Size(31, 15);
            FIO.TabIndex = 1;
            FIO.Text = "Имя";
            // 
            // Pasport
            // 
            Pasport.AutoSize = true;
            Pasport.Location = new Point(23, 267);
            Pasport.Name = "Pasport";
            Pasport.Size = new Size(146, 15);
            Pasport.TabIndex = 1;
            Pasport.Text = "Серия и Номер паспорта";
            // 
            // Birth
            // 
            Birth.AutoSize = true;
            Birth.Location = new Point(23, 216);
            Birth.Name = "Birth";
            Birth.Size = new Size(90, 15);
            Birth.TabIndex = 1;
            Birth.Text = "Дата рождения";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 448);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Birth);
            Controls.Add(Pasport);
            Controls.Add(FIO);
            Controls.Add(Pass);
            Controls.Add(Login);
            Controls.Add(Namee);
            Controls.Add(dataGridView1);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label Namee;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Label Login;
        private Label Pass;
        private Label FIO;
        private Label Pasport;
        private Label Birth;
    }
}