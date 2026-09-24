using Dapper;
using DataAccess.Configuration;
using DataAccess.Models;
using Microsoft.Extensions.Options;
using System.Data;

namespace DataAccess.DataAccess;

public class UserCredentialsData
{
    private readonly ISQLDataAccess _dbAccess;
    private readonly IOptions<ConnectionStringOptions> _connectionStringOptions;

    public UserCredentialsData(ISQLDataAccess dbAccess, IOptions<ConnectionStringOptions> connectionStringOptions)
    {
        _dbAccess = dbAccess;
        _connectionStringOptions = connectionStringOptions;
    }

    public async Task<int> CreateUserCredentials(UserCredentialsModel newUserCredentials)
    {
        var dynamicParameters = new DynamicParameters();
        dynamicParameters.Add(nameof(UserCredentialsModel.Id), dbType: DbType.Int32, direction: ParameterDirection.Output);
        dynamicParameters.Add(nameof(UserCredentialsModel.EmailAddress), newUserCredentials.EmailAddress);
        dynamicParameters.Add(nameof(UserCredentialsModel.HashedPassword), newUserCredentials.HashedPassword);

        await _dbAccess.SaveDataAsync("dbo.spUserCredentials_Create", dynamicParameters, _connectionStringOptions.Value.SQLServerConnectionString);

        return dynamicParameters.Get<int>(nameof(UserCredentialsModel.Id));
    }

    public async Task<UserCredentialsModel> GetUserCredentialsByEmailAddressAsync(string emailAddress)
    {
        var userCredentials = await _dbAccess.LoadDataAsync<UserCredentialsModel, dynamic>("dbo.spUserCredentials_GetByEmailAddress",
                                                                                           new { emailAddress },
                                                                                           _connectionStringOptions.Value.SQLServerConnectionString);
        return userCredentials.FirstOrDefault();
    }

    public async Task<UserCredentialsModel> GetUserCredentialsByIdAsync(int id)
    {
        var userCredentials = await _dbAccess.LoadDataAsync<UserCredentialsModel, dynamic>("dbo.spUserCredentials_GetById",
                                                                                           new { id },
                                                                                           _connectionStringOptions.Value.SQLServerConnectionString);
        return userCredentials.FirstOrDefault();
    }
}
