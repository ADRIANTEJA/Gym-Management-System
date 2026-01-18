

namespace DataAccess.DataAccess;

public class MembershipData
{
    private ISQLDataAccsess _dbAccess;
    private ConnectionStringData _connectionStringData;

    public MembershipData(ISQLDataAccsess dbAccess, ConnectionStringData connectionStringData)
    {
        _dbAccess = dbAccess;
        _connectionStringData = connectionStringData;
    }
}
