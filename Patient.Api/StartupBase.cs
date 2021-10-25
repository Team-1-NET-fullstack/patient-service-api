//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using Patient.Api.Models;
//using System;
//using Microsoft.Extensions.Configuration;
//namespace Patient.Api
//{
//    public class StartupBase
//    {

//        // This method gets called by the runtime. Use this method to add services to the container.
//        public void ConfigureServices(IServiceCollection services)
//        {
//            try
//            {
//                services.AddControllers();
//                services.AddSwaggerGen();
//                string dbconn = Configuration.GetSection("ConnectionString").GetSection("dbConn").Value;
//                services.AddDbContext<CTGeneralHospitalContext>(opts => opts.UseSqlServer(CTGeneralHospital["ConnectionString:dbconn"]));

//                //services.AddDbContext<CTGeneralHospitalContext>(options => options.UseLazyLoadingProxies().UseSqlServer(dbconn));
//                //  services.AddScoped<IPatientsRepository, PatientRepository>();
//            }
//            catch (Exception)
//            {

//            }
//        }
//    }
//}