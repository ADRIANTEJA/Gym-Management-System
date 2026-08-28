using DataAccess.Models;

namespace DataAccess.DataAccess;

public class MemberData
{
    private ISQLDataAccess _dbAccess;
    private ConnectionStringData _connectionStringData;

    public MemberData(ISQLDataAccess dbAccess, ConnectionStringData connectionStringData)
    {
        _dbAccess = dbAccess;
        _connectionStringData = connectionStringData;
    }

    public async Task<T> CreateMember<U, T>(U newMember)
    {
        return await _dbAccess.SaveDataAsync<U, T>("dbo.spMember_Create", newMember, _connectionStringData.SQLDBConnectionName);
    }
}
