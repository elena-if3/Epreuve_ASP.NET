using System;
using Microsoft.Extensions.Configuration;

namespace DAL.Services
{
    public abstract class BaseService
    {
        protected readonly string _connectionString;

        protected BaseService(IConfiguration configuration, string dbname)
        {
            _connectionString = configuration.GetConnectionString(dbname) ?? throw new ArgumentException(nameof(dbname));
        }
    }
}
