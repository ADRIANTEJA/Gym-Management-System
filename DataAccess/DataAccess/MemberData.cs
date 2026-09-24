using Dapper;
using DataAccess.Configuration;
using DataAccess.Models;
using Microsoft.Extensions.Options;

namespace DataAccess.DataAccess;

public class MemberData
{
    private readonly ISQLDataAccess _dbAccess;
    private readonly IOptions<ConnectionStringOptions> _connectionStringOptions;

    public MemberData(ISQLDataAccess dbAccess, IOptions<ConnectionStringOptions> connectionStringOptions)
    {
        _dbAccess = dbAccess;
        _connectionStringOptions = connectionStringOptions;
    }

    public async Task<int> CreateMember(MemberModel newMember)
    {
        var dynamicParameters = new DynamicParameters();
        dynamicParameters.Add(nameof(MemberModel.FullName), newMember.FullName);
        dynamicParameters.Add(nameof(MemberModel.Age), newMember.Age);
        dynamicParameters.Add(nameof(MemberModel.PhoneNumber), newMember.PhoneNumber);
        dynamicParameters.Add(nameof(MemberModel.PersonalId), newMember.PersonalId);

        await _dbAccess.SaveDataAsync("dbo.spMember_Create", dynamicParameters, _connectionStringOptions.Value.SQLServerConnectionString);

        return dynamicParameters.Get<int>(nameof(MemberModel.Id));
    }
}
