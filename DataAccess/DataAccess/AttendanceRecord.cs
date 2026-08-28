

namespace DataAccess.DataAccess;

public class AttendanceRecord
{
    private ISQLDataAccess _dbAccess;
    private ConnectionStringData _connectionStringData;

    public AttendanceRecord(ISQLDataAccess dbAccess, ConnectionStringData connectionStringData)
    {
        _dbAccess = dbAccess;
        _connectionStringData = connectionStringData;
    }
}
