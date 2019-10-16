using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Schedule.BL;
using Schedule.Interfaces;
using Schedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.DI
{
    public class Init
    {
        public static void ConfigureServices(IServiceCollection services, string connection)
        {
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(connection));
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped(typeof(ISchedule), typeof(Schedule));
            services.AddHttpContextAccessor();
        }
    }
}
