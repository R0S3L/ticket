using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Threading.Channels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tickets
{
    public partial class Authorization : Form
    {
        string SQLconnect = "server = localhost; port=3306; userid=root; password=t9qd9jqs; database=train_tickets_sokolov; sslmode=none; charset=utf8 ";

        public Authorization()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Enter_User()
        {
            MySqlConnection con1 = new MySqlConnection(SQLconnect);
            con1.Open();
            string query = "SELECT * FROM user WHERE Логин=@login and Пароль=@password";
            MySqlCommand com = new MySqlCommand(query, con1);
            com.Parameters.AddWithValue("@login", textBox1.Text);
            com.Parameters.AddWithValue("@password", textBox2.Text);
            MySqlDataReader Dr = com.ExecuteReader();
            if (Dr.HasRows == true)
            {
                Main main = new Main();
                main.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Такого логина или пароля не существует: \n\n1) Проверьте правильность ввода\n\n2) Обратитесь к администартору", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void Enter_Adm()
        {
            MySqlConnection con1 = new MySqlConnection(SQLconnect);
            con1.Open();
            string query = "SELECT * FROM admin WHERE Логин=@login and Пароль=@password";
            MySqlCommand com = new MySqlCommand(query, con1);
            com.Parameters.AddWithValue("@login", textBox1.Text);
            com.Parameters.AddWithValue("@password", textBox2.Text);
            MySqlDataReader Dr = com.ExecuteReader();
            if (Dr.HasRows == true)
            {
                Adm_Main main = new Adm_Main();
                main.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Такого логина или пароля не существует: \n\n1) Проверьте правильность ввода", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enter_User();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enter_Adm();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Reg rg = new Reg();
            this.Hide();
            rg.Show();
        }
    }
}