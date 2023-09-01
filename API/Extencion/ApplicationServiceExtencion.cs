using Core.Interfaces;
using Infractructure.Repository;

namespace API.Extencion
{
    public static  class ApplicationServiceExtencion
    {
        public static void ConfigureCors (this IServiceCollection services) =>
            services.AddCors (
                options =>
                {
                    options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
                }
                );


        public static void AddAplicationServices(this IServiceCollection services) 
        
        
        { 
        
         services.AddScoped(typeof(IGeneryRepository<>), typeof(RepsitoryGeneric<>));
         services.AddScoped<IUserRepository, UserRepository>(); 


        }

    }
}
