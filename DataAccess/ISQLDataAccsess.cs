
namespace DataAccess;

public interface ISQLDataAccsess
{
    Task<List<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters, string connectionStringName);
    Task<int> SaveDataAsync<U>(string storedProcedure, U parameters, string connectionStringName);
}
