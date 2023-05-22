using MySql.Data.MySqlClient;

public static class DatabaseConnection
{
    public static MySqlConnection Connection { get; private set; }

    public static void Initialize(string connectionString)
    {
        Connection = new MySqlConnection(connectionString);
    }
}
