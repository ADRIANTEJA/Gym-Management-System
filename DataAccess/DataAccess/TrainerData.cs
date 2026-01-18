

namespace DataAccess.DataAccess;

public class TrainerData
{
    private ISQLDataAccsess _dbAccess;
    private ConnectionStringData _connectionStringData;

    public TrainerData(ISQLDataAccsess dbAccess, ConnectionStringData connectionStringData)
    {
        _dbAccess = dbAccess;
        _connectionStringData = connectionStringData;
    }
}
