using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using PatientModule.API.Models;
using PatientModule.API.PatientModule.API.BAL.PatientModule.API.BAL.Interfaces;
using PatientModule.API.PatientModule.API.BAL.PatientModule.API.BAL.Services;
using PatientModule.API.PatientModule.API.DAL.PatientModule.API.DAL.Implementations;
using PatientModule.API.PatientModule.API.DAL.PatientModule.API.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientModule.API
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PatientModule.API", Version = "v1" });
            });

            services.AddDbContext<CTGeneralHospitalContext>(opts => opts.UseSqlServer(Configuration["ConnectionStrings:dbconn"]));
            string dbconn = Configuration.GetSection("ConnectionString").GetSection("dbConn").Value;
            services.AddScoped<IPateintService<Patient>, PatientService>();
            services.AddScoped<IPatientRepository<Patient>, PatientRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PatientModule.API v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
