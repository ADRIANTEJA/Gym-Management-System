

namespace DataAccess.DataAccess;

public class AttendanceRecord
{
    private ISQLDataAccsess _dbAccess;
    private ConnectionStringData _connectionStringData;

    public AttendanceRecord(ISQLDataAccsess dbAccess, ConnectionStringData connectionStringData)
    {
        _dbAccess = dbAccess;
        _connectionStringData = connectionStringData;
    }
}
