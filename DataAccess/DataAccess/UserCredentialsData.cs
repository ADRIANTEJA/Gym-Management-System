using DataAccess.Models;

namespace DataAccess.DataAccess;

public class UserCredentialsData
{
    private ISQLDataAccsess _dbAccess;
    private ConnectionStringData _connectionStringData;

    public UserCredentialsData(ISQLDataAccsess dbAccess, ConnectionStringData connectionStringData)
    {
        _dbAccess = dbAccess;
        _connectionStringData = connectionStringData;
    }

    public Task<int> CreateUserCredentials(UserCredentialsModel newUserCredentials)
    {
        return _dbAccess.SaveDataAsync("dbo.spUserCredentias_Create", newUserCredentials, _connectionStringData.SQLDBConnectionName);
    }

    public async Task<UserCredentialsModel> GetUserCredentialsAsync(int id)
    {
        var userCredentials = await _dbAccess.LoadDataAsync<UserCredentialsModel, dynamic>("dbo.spUserCredentials_GetById",
                                                                                           new { id },
                                                                                           _connectionStringData.SQLDBConnectionName);

        return userCredentials.FirstOrDefault();
    }
}
