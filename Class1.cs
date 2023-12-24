using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    public Class1()
    {
        //
        // TODO: Add constructor logic here
        //
        int vagonId = 0;
        int available = 0;
        int maxAvailable = 10;

        MySqlConnection connection = new MySqlConnection(SQLconnect);
        {
            connection.Open();

            // Поиск комнаты по номеру
            string selectQuery = "SELECT * FROM tickets WHERE Вагон = @PlaceNumber";
            MySqlCommand command = new MySqlCommand(selectRoomQuery, connection);
            {
                command.Parameters.AddWithValue("@PlaceNumber", textBox6);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        vagonId = reader["Вагон"];
                        available = maxAvailable - reader.Count["Место"];
                    }
                    else
                    {
                        MessageBox.Show("Вагон не найден");
                        return;
                    }
                }
            }

            // Проверка наличия свободных мест
            if (available <= 0)
            {
                MessageBox.Show("В вагоне нет свободных мест", "Ошибка", MessageBoxButton.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}   
