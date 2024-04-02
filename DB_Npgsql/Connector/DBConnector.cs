using DB_Npgsql.Helpers.Configuration;
using Npgsql;

namespace DB_Npgsql.Connector;

public class DBConnector
{
    public NpgsqlConnection Connection { get; init; }
    
    public DBConnector()
    {
        var connectionString =
            $"Host={Configurator.DbSettings.DB_Server};" +
            $"Port={Configurator.DbSettings.DB_Port};" +
            $"Database={Configurator.DbSettings.DB_Name};" +
            $"User Id={Configurator.DbSettings.DB_Username};" +
            $"Password={Configurator.DbSettings.DB_Password};";

        Connection = new NpgsqlConnection(connectionString);
        
        Connection.Open();
    }

    public void CloseConnection()
    {
        Connection.Close();
    }
}