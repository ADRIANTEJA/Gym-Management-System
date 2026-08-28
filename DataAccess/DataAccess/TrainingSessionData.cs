

namespace DataAccess.DataAccess;

public class TrainingSessionData
{
    private ISQLDataAccess _dbAccess;
    private ConnectionStringData _connectionStringData;

    public TrainingSessionData(ISQLDataAccess dbAccess, ConnectionStringData connectionStringData)
    {
        _dbAccess = dbAccess;
        _connectionStringData = connectionStringData;
    }
}
