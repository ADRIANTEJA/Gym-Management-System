

namespace DataAccess.DataAccess;

public class ScheduleData
{
    private ISQLDataAccsess _dbAccess;
    private ConnectionStringData _connectionStringData;

    public ScheduleData(ISQLDataAccsess dbAccess, ConnectionStringData connectionStringData)
    {
        _dbAccess = dbAccess;
        _connectionStringData = connectionStringData;
    }
}
