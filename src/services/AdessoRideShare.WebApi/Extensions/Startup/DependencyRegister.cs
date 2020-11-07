using AdessoRideShare.Repository.DataAccess.Abstract;
using AdessoRideShare.Repository.DataAccess.Concerete;
using Microsoft.Extensions.DependencyInjection;

namespace AdessoRideShare.WebApi.Extensions.Startup
{
    public static class DependencyRegister
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITravelPlanRepository, TravelPlanRepository>();
            services.AddScoped<ITravelPlanUserRepository, TravelPlanUserRepository>();

            return services;
        }
    }
}
