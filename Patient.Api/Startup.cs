using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Patient.Api.Models;
using Patient.Api.Models.Repository;
using System;

namespace Patient.Api
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
            try
            {
                services.AddControllers();
                services.AddSwaggerGen();
                services.AddDbContext<CTGeneralHospitalContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:dbconn"]));
                //string dbconn = Configuration.GetSection("ConnectionString").GetSection("dbConn").Value;
                //services.AddDbContext<CTGeneralHospitalContext>(options => options.UseLazyLoadingProxies().UseSqlServer(dbconn));
                services.AddScoped<IPatientsRepository, PatientRepository>();
            }
            catch (Exception)
            {

            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            try
            {
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Patients API V1");
                //   c.RoutePrefix = string.Empty;
            });
            }
            catch(Exception)
            {

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
