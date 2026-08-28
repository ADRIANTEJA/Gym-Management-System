

namespace DataAccess.DataAccess;

public class TrainerData
{
    private ISQLDataAccess _dbAccess;
    private ConnectionStringData _connectionStringData;

    public TrainerData(ISQLDataAccess dbAccess, ConnectionStringData connectionStringData)
    {
        _dbAccess = dbAccess;
        _connectionStringData = connectionStringData;
    }
}
