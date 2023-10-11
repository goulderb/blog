using System.Data;
using Blog.Web.API.Settings;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace Blog.Web.API.DBContext
{
    public class BlogContext
    {
        private readonly IOptionsMonitor<SQLServerSetttings> _sqlServerSettingsMonitor;

        public BlogContext(IOptionsMonitor<SQLServerSetttings> sqlServerSettingsMonitor)
        {
            _sqlServerSettingsMonitor = sqlServerSettingsMonitor;
        }

        public IDbConnection CreateConnection() => new SqlConnection(_sqlServerSettingsMonitor.CurrentValue.ConnectionString);
    }
}