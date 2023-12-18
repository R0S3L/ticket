using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tickets
{
    public partial class NewTicket : Form
    {
        object id;
        string SQLconnect = "server = localhost; port=3306; userid=root; password=t9qd9jqs; database=train_tickets_sokolov; sslmode=none; charset=utf8 ";
        public NewTicket(object id)
        {
            InitializeComponent();
            this.id = id;
            get_reis();
        }
        void get_reis()
        {
            MySqlConnection conn = new MySqlConnection(SQLconnect);
            conn.Open();
            string query = $"SELECT * FROM `reis`  WHERE `idreis`='{id}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                textBox1.Text = read["Пункт_Отправки"].ToString();
                textBox2.Text = read["Пункт_Назначения"].ToString();
                textBox3.Text = read["Дата_и_Время"].ToString();
                textBox5.Text = read["Цена"].ToString();
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(SQLconnect);
            con.Open();
            string buyquery = "INSERT INTO `tickets`(`Место_Отправки`,`Место_Назначения`,`Дата_и_Время`,`Место`,`Цена`)" +
                " VALUES(" +
                $"'{textBox1.Text}'," +
                $"'{textBox2.Text}'," +
                $"'{textBox3.Text}'," +
                $"'{textBox4.Text}'," +
                $"'{textBox5.Text}'," +
                ")";
            MySqlCommand cmd = new MySqlCommand(buyquery, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
