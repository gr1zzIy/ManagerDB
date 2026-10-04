using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using ManagerDB.Models;

namespace ManagerDB.Data;

public class FacultyRepository
{
    private readonly DbConnectionFactory _dbConnectionFactory;

    public FacultyRepository(DbConnectionFactory dbConnectionFactory)
    {
        _dbConnectionFactory = dbConnectionFactory;
    }

    public async Task<List<Faculty>> GetAllAsync()
    {
        const string sql = """
                           select 
                               faculty_id as Id, 
                               faculty_name as Name
                           from faculties
                           """;

        await using var connection = _dbConnectionFactory.CreateConnection();
        var result = await connection.QueryAsync<Faculty>(sql);
        
        return result.AsList();
    }
    
    public async Task AddAsync(string name)
    {
        const string sql = """
                           insert into faculties (faculty_name) 
                           values (@Name)
                           """;

        await using var connection = _dbConnectionFactory.CreateConnection();
        await connection.ExecuteAsync(sql, new { Name = name} );
    }
    
    public async Task UpdateAsync(int id, string name)
    {
        const string sql = """
                           update faculties 
                           set faculty_name = @Name 
                           where faculty_id = @Id
                           """;

        await using var connection = _dbConnectionFactory.CreateConnection();
        await connection.ExecuteAsync(sql, new { Id = id, Name = name });
    }
    
    public async Task DeleteAsync(int id)
    {
        const string sql = """
                           delete from faculties 
                           where faculty_id = @Id
                           """;

        await using var connection = _dbConnectionFactory.CreateConnection();
        await connection.ExecuteAsync(sql, new { Id = id });
    }
}