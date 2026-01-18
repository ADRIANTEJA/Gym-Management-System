

namespace DataAccess.DataAccess;

public class TrainingSessionData
{
    private ISQLDataAccsess _dbAccess;
    private ConnectionStringData _connectionStringData;

    public TrainingSessionData(ISQLDataAccsess dbAccess, ConnectionStringData connectionStringData)
    {
        _dbAccess = dbAccess;
        _connectionStringData = connectionStringData;
    }
}
