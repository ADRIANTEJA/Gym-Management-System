using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess;

public class SQLServerAccess : ISQLDataAccess
{
    public async Task<List<T>> LoadDataAsync<T, U>(string storedProcedure, U dynamicParameters, string connectionString) where U : class
    {
        await using var connection = new SqlConnection(connectionString);

        var rows = await connection.QueryAsync<T>(storedProcedure, dynamicParameters, commandType: CommandType.StoredProcedure);

        return rows.ToList();
    }

    public async Task<int> SaveDataAsync<U>(string storedProcedure, U dynamicParameters, string connectionString) where U : class
    {
        var command = new CommandDefinition(storedProcedure, dynamicParameters, commandType: CommandType.StoredProcedure);

        await using var connection = new SqlConnection(connectionString);

        return await connection.ExecuteAsync(command);
    }
}
