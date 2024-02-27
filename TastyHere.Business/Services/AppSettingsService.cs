using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyHere.DataAccess;

namespace TastyHere.Business.Services
{
    public static class AppSettingsService
    {

        public static void AddDbContext(IServiceCollection services, string connectionString)
            => ContextConnector.AddDbContext(services, connectionString);
    }
}
