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

namespace Tickets
{
    public partial class Main : Form
    {
        string SQLconnect = "server = localhost; port=3306; userid=root; password=t9qd9jqs; database=train_tickets_sokolov; sslmode=none; charset=utf8 ";
        public Main()
        {
            InitializeComponent();
            get_data();
        }
        void get_data()
        {
            MySqlConnection conn = new MySqlConnection(SQLconnect);
            conn.Open();
            String que = "SELECT * FROM `tickets` as tick left join `user` AS us ON `us`.`iduser`= `tick`.`iduser` left join `reis` AS rs ON `rs`.`idreis` = `tick`.`idreis`  ";
            MySqlDataAdapter msda = new MySqlDataAdapter(que, conn);
            DataTable table = new DataTable();
            msda.Fill(table);
            dataGridView1.DataSource = table;
            //invisible columns
            dataGridView1.Columns["idreis"].Visible = false;
            dataGridView1.Columns["iduser"].Visible = false;
            dataGridView1.Columns["idtickets"].Visible = false;
            dataGridView1.Columns["Кол-во_Вагонов"].Visible = false; 
            dataGridView1.Columns["Кол-во_Билетов"].Visible = false; 
            dataGridView1.Columns["idreis1"].Visible = false;
            dataGridView1.Columns["iduser1"].Visible = false;
            dataGridView1.Columns["Логин"].Visible = false;
            dataGridView1.Columns["Пароль"].Visible = false;
            dataGridView1.Columns["Дата_Рождения"].Visible = false;
            dataGridView1.Columns["Серия_Номер_Паспорта"].Visible = false;
            //columns in the right position
            dataGridView1.Columns["Пункт_Отправки"].DisplayIndex = 0;
            dataGridView1.Columns["Пункт_Назначения"].DisplayIndex = 1;
            dataGridView1.Columns["ФИО"].DisplayIndex = 2;
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
