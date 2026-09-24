using DataAccess.Configuration;
using Microsoft.Extensions.Options;

namespace DataAccess.DataAccess;

public class ScheduleData
{
    private readonly ISQLDataAccess _dbAccess;
    private readonly IOptions<ConnectionStringOptions> _connectionStringOptions;

    public ScheduleData(ISQLDataAccess dbAccess, IOptions<ConnectionStringOptions> connectionStringOptions)
    {
        _dbAccess = dbAccess;
        _connectionStringOptions = connectionStringOptions;
    }
}
