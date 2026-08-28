
namespace DataAccess;

public interface ISQLDataAccess
{
    Task<List<T>> LoadDataAsync<U, T>(string storedProcedure, U parameters, string connectionStringName);
    Task<T> SaveDataAsync<U, T>(string storedProcedure, U parameters, string connectionStringName);
}
