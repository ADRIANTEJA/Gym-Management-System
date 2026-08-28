

namespace DataAccess.DataAccess;

public class MembershipData
{
    private ISQLDataAccess _dbAccess;
    private ConnectionStringData _connectionStringData;

    public MembershipData(ISQLDataAccess dbAccess, ConnectionStringData connectionStringData)
    {
        _dbAccess = dbAccess;
        _connectionStringData = connectionStringData;
    }
}
