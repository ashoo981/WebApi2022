using Microsoft.Extensions.DependencyInjection;
using App.Business.Services;

namespace App.WebApi.Registrations
{
    public static class ServiceRegistration
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<GeomahalleService>();
            services.AddScoped<BanksService>();
            services.AddScoped<BankBrachService>();
            services.AddScoped<BankAccountService>();
            services.AddScoped<CustomerService>();
            services.AddScoped<CustomerAdressService>();

        }
    }
}
