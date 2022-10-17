//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
using System.Runtime.InteropServices;
using System.Reflection;
using Microsoft.OpenApi.Models;
using Hart.Contracts;
using Hart.Contracts.Services;
using Hart.Data.Providers;
using Hart.Services;
using Hart.Data;
using Hart.Data.Repositories;
using Hart.Contracts.Repositories;


//--------------------------------------------------------------------------
// Namespace Section
//--------------------------------------------------------------------------
namespace Hart.Extensions
{
    //----------------------------------------------------------------------
    // Class Section
    //----------------------------------------------------------------------
    public static class ServicesExtensions
    {
        //------------------------------------------------------------------
        // Configure CORS
        //------------------------------------------------------------------
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options => {
                options.AddPolicy(
                    "CorsPolicy",
                    builder =>
                        builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                );
            });
        }

        //------------------------------------------------------------------
        // Configure IIS
        //------------------------------------------------------------------
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(
                options => {

                }
            );
        }

        //------------------------------------------------------------------
        // Configure Logging
        //------------------------------------------------------------------
        public static void ConfigureLogger(this IServiceCollection services)
        {
            services.AddScoped<ILoggerManager, LoggerManager>();
        }

        //------------------------------------------------------------------
        // Configure ConnectionString Provider
        //------------------------------------------------------------------
        public static void ConfigureConnectionString(
            this
            IServiceCollection services,
            IConfiguration config
        )
        {
            string connStr = String.Empty;
            connStr = config.GetConnectionString("connectionString");

            services.AddScoped<IConnectionStringProvider>(
                provider => new ConnectionStringProvider(connStr)
            );
        }

        //------------------------------------------------------------------
        // Configure Data Context
        //------------------------------------------------------------------
        public static void ConfigureDataContext(this IServiceCollection services)
        {
            services.AddDbContext<RepositoryDataContext>();
        }

        //------------------------------------------------------------------
        // Configure Data Repository Manager
        //------------------------------------------------------------------
        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }

        //------------------------------------------------------------------
        // Configure Swagger
        //------------------------------------------------------------------ 
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(

                swaggerOptions =>
                {
                    swaggerOptions.SwaggerDoc(
                        "v1",
                        new OpenApiInfo
                        {
                            Title = "WilldelaVega.com API",
                            Version = "v1",
                            Description = "Base Scaffold API",
                            TermsOfService = new Uri("https://example.com/terms"),
                            Contact = new OpenApiContact
                            {
                                Name = "Will de la Vega",
                                Email = "info@willdelavega.com",
                                Url = new Uri("https://twitter.com/willdelavega")
                            },
                            License = new OpenApiLicense
                            {
                                Name = "Base Scaffold API LICX",
                                Url = new Uri("https://apis.willdelavega.com/license")
                            }
                        }
                    );

                    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                    swaggerOptions.IncludeXmlComments(xmlPath);
                }
            );
        }

    }
}
