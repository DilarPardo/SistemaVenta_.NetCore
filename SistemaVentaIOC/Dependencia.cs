using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using SistemaVentaDAL.DBContext;
using Microsoft.Extensions.Options;
using SistemaVentaEntity;
using SistemaVentaDAL.Implementacion;
using SistemaVentaDAL.Interfaces;
using SistemaVentaBLL.Interfaces; 
using SistemaVentaBLL.Implementacion;





namespace SistemaVentaIOC
{
    public static class Dependencia
    {

        public static void InyectarDependencia(this IServiceCollection services, IConfiguration Configuration)
        {

            services.AddDbContext<DbventaContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("CadenaSQL"));
            });

            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IVentaRepository, VentaRepository>();


            services.AddScoped<ICorreoService, CorreoService>();

            services.AddScoped<IFireBaseService, FireBaseService>();

            services.AddScoped<IUtilidadesService, UtilidadesServices>();

            services.AddScoped<IRolService, RolService>();


        }

    }
}
