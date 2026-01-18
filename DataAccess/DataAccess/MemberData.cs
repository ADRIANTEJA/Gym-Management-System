using DataAccess.Models;

namespace DataAccess.DataAccess;

public class MemberData
{
    private ISQLDataAccsess _dbAccess;
    private ConnectionStringData _connectionStringData;

    public MemberData(ISQLDataAccsess dbAccess, ConnectionStringData connectionStringData)
    {
        _dbAccess = dbAccess;
        _connectionStringData = connectionStringData;
    }

    public async Task<int> CreateMember(MemberModel newMember)
    {
        return await _dbAccess.SaveDataAsync("dbo.spMember_Create", newMember, _connectionStringData.SQLDBConnectionName);
    }
}
