using Microsoft.Extensions.DependencyInjection;

namespace BookMyHall.Configurations.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Register application services here
            //services.AddScoped<IBookingService, BookingService>();
            

            // Add more services as needed
            return services;
        }
    }
}
