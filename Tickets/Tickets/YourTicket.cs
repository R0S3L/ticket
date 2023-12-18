using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tickets
{
    public partial class YourTicket : Form
    {
        string SQLconnect = "server = localhost; port=3306; userid=root; password=t9qd9jqs; database=train_tickets_sokolov; sslmode=none; charset=utf8 ";
        object ticketId = null;
        int userId;
        public YourTicket(object ticketId)
        {
            InitializeComponent();
            this.ticketId = ticketId;
            get_ticket();

        }
        void get_ticket()
        {
            MySqlConnection conn = new MySqlConnection(SQLconnect);
            conn.Open();
            string query = "SELECT * FROM `tickets`  " +
                $" LEFT JOIN `user` ON (`user`.`iduser`= `tickets`.`iduser`)" +
                $" LEFT JOIN `reis`  ON (`reis`.`idreis` = `tickets`.`idreis`)" +
                $" WHERE `tickets`.`idtickets`='{ticketId}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                textBox1.Text = read["Пункт_Отправки"].ToString();
                textBox2.Text = read["Пункт_Назначения"].ToString();
                textBox3.Text = read["Цена"].ToString();
                textBox4.Text = read["Вагон"].ToString();
                textBox5.Text = read["Место"].ToString();
                textBox7.Text = read["Платформа"].ToString();
                textBox6.Text = read["Дата_и_Время"].ToString();
                textBox8.Text = read["ФИО"].ToString();
                textBox9.Text = read["Серия_Номер_Паспорта"].ToString();
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите отменить бронь?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection(SQLconnect);
                con.Open();
                string DelQeury = $"Delete from `tickets` where `iduser`='{userId}'";
                MySqlCommand cmdDel = new MySqlCommand(DelQeury, con);
                cmdDel.ExecuteNonQuery();
                MessageBox.Show("Бронь отменена успешно", "Успешно удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                con.Close();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Изменения отменены", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
