using MySqlConnector;

namespace CitiesAndStatesFilling
{
    public static class StringConnection
    {
        public static MySqlConnectionStringBuilder GetStringConnection()
        {
            return new MySqlConnectionStringBuilder()
            {
                Server = "localhost",
                Database = "advocacy_database",
                UserID = "root",
                Password = "983453069",
                SslMode = MySqlSslMode.Required,
            };
        }
    }
}
