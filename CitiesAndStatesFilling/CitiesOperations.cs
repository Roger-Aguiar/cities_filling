using System;
using System.Collections.Generic;
using MySqlConnector;
using System.IO;
using System.Windows.Forms;

namespace CitiesAndStatesFilling
{
    public class CitiesOperations
    {
        public void Insert()
        {
            var states = GetStates();
            var cities = ReadFile(states);

            foreach (var item in cities)
            {
                string sql = $"INSERT INTO Cities(City, IdState) VALUES('{item.City}', {item.IdState})";
                try
                {
                    MySqlConnection connection = new MySqlConnection(StringConnection.GetStringConnection().ToString());

                    MySqlCommand sqlCommand = new MySqlCommand(sql, connection);
                    sqlCommand.Parameters.Add(new MySqlParameter("@City", item.City));
                    sqlCommand.Parameters.Add(new MySqlParameter("@IdState", item.IdState));

                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }          
        }

        private List<States> GetStates() 
        {
            var states = new List<States>();
            string sql = "SELECT * FROM States";

            try
            {
                MySqlConnection connection = new MySqlConnection(StringConnection.GetStringConnection().ToString());
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        states.Add(new States()
                        {
                            IdState = reader.GetInt32(0),
                            State = reader.GetString(1),
                        });
                    }
                };
                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return states;
        }

        public static List<Cities> ReadFile(List<States> states)
        {
            var cities = new List<Cities>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            foreach(var line in File.ReadLines(openFileDialog.FileName))
            {
                var lineSplit = line.Replace("\t", " ").Split();
                var city = "";

                for(int i = 1; i < lineSplit.Length; i++) 
                {
                    city += lineSplit[i] + " ";
                }

                cities.Add(new Cities()
                {
                    Uf = lineSplit[0],
                    City = city.Trim(),
                    IdState = GetIdState(states, lineSplit[0].Trim())
                });
            }
            return cities;
        }

        private static int GetIdState(List<States> states, string UF) 
        {
            int idState = 0;

            foreach(var state in states) 
            {
                if(state.State == UF)
                {
                    idState = state.IdState; 
                    break;
                }
            }
            return idState;
        }        
    }
}
