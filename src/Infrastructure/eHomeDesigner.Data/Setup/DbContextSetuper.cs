using eHomeDesigner.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Data.Setup;

public static class DbContextSetuper
{
    public static void SetupDbContext(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<DeviceDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        services.AddDbContext<FurnitureDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
    }
}
