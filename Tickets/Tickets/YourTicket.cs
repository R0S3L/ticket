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
        object ticketId;
        public YourTicket(object ticketId)
        {
            InitializeComponent();
            get_ticket();
            this.ticketId = ticketId;
        }
        void get_ticket()
        {
            MySqlConnection conn = new MySqlConnection(SQLconnect);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            conn.Open();
            string query = "SELECT * FROM `tickets` + " +
                $" LEFT JOIN `user` ON (`user`.`iduser`= `tickets`.`iduser`)" +
                $" LEFT JOIN `reis`  ON (`reis`.`idreis` = `tickets`.`idreis`)" +
                $" WHERE `user`.`iduser`='{ticketId}'";
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            while (read.Read())
            {
                try
                {
                    label1.Text = read["Пункт_Отправки"].ToString();
                    label2.Text = read["Пункт_Назначения"].ToString();
                    label3.Text = read["Цена"].ToString();
                    label4.Text = read["Вагон"].ToString();
                    label5.Text = read["Место"].ToString();
                    label8.Text = read["ФИО"].ToString();
                    label7.Text = read["Платформа"].ToString();
                    label6.Text = read["Дата_и_Время"].ToString();
                    label9.Text = read["Серия_Номер_Паспорта"].ToString();
                }
                catch { }
            }
            conn.Close();
        }
    }
}
