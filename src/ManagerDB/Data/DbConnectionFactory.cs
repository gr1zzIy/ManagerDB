using Microsoft.Data.SqlClient;

namespace ManagerDB.Data;

public sealed class DbConnectionFactory
{
    private readonly string _connectionString;
    
    public DbConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    public SqlConnection CreateConnection()
    {
        return new SqlConnection(_connectionString);
    }
}