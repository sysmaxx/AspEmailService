using EmailServiceLibrary.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EmailServiceLibrary.Extensions
{
    public static class ServiceCollectionExtension
    {
        /// <summary>
        /// Add the SMTP Service to scoped services
        /// </summary>
        /// <param name="services"></param>
        public static void AddEmailService(this IServiceCollection services)
        {
            services.AddScoped<IEmailService, EmailService>();
        }
    }
}
