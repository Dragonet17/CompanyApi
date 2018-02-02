using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FL.Infrastructure.DAL;
using FL.Infrastructure.Factories;
using FL.Infrastructure.Factories.Interfaces;
using FL.Infrastructure.Repositories;
using FL.Infrastructure.Repositories.Interfaces;
using FL.Infrastructure.Services;
using FL.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace FL.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddJsonOptions(x => x.SerializerSettings.Formatting = Formatting.Indented);
            services.AddCors();
            #region DbContext

            services.AddDbContext<FLContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("FLDatabase"),b => b.MigrationsAssembly("FL.API")));

            //services.AddAutoMapper(x => x.AddProfile(new MappingsProfile()));

            #endregion

            #region Repositories

            services.AddScoped<IEmpoyeeRepository, EmployeeRepository>();

            #endregion

            #region Services

            services.AddScoped<IEmployeeService, EmployeeService>();

            #endregion

            #region Factories

            services.AddScoped<IEmailFactory, EmailFactory>();
            services.AddScoped<IEmployeeFactory, EmployeeFactory>();


            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().AllowCredentials());
            app.UseMvc();
        }
    }
}
