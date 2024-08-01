using System.Data;
using Grocery.Tracking.Web.API.Settings;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace Grocery.Tracking.Web.API.DBContext;

public class BlogContext(IOptionsMonitor<SQLServerSetttings> sqlServerSettingsMonitor)
{
    private readonly IOptionsMonitor<SQLServerSetttings> _sqlServerSettingsMonitor = sqlServerSettingsMonitor;

    public IDbConnection CreateConnection() => new SqlConnection(_sqlServerSettingsMonitor.CurrentValue.ConnectionString);
}