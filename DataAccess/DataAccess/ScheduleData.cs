

namespace DataAccess.DataAccess;

public class ScheduleData
{
    private ISQLDataAccess _dbAccess;
    private ConnectionStringData _connectionStringData;

    public ScheduleData(ISQLDataAccess dbAccess, ConnectionStringData connectionStringData)
    {
        _dbAccess = dbAccess;
        _connectionStringData = connectionStringData;
    }
}
