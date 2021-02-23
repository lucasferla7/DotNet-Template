using Microsoft.Extensions.DependencyInjection;
using Template.Services.People;

namespace Template.API.Settings
{
    public static class ServiceDependencyInjection
    {
        public static void SetupServiceDependecyInjection(this IServiceCollection services)
        {
            services.AddTransient<IPeopleService, PeopleService>();
        }
    }
}
