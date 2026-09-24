
namespace DataAccess;

public interface ISQLDataAccess
{
    Task<List<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters, string connectionStringName) where U : class;
    Task<int> SaveDataAsync<U>(string storedProcedure, U parameters, string connectionStringName) where U : class;
}
