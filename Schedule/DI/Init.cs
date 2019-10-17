using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Schedule.BL;
using Schedule.Interfaces;
using Schedule.Models;


namespace Schedule.DI
{
    public class Init
    {
        public static void ConfigureServices(IServiceCollection services, string connection)
        {

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped(typeof(IScheduleRepository), typeof(ScheduleRepository));
          
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddHttpContextAccessor();
            services.AddDbContext<ApplicationDbContext>(ServiceLifetime.Transient);

            services.AddHttpContextAccessor();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddHttpContextAccessor();
            services.AddDbContext<ApplicationDbContext>(ServiceLifetime.Transient);
        }
    }
}
