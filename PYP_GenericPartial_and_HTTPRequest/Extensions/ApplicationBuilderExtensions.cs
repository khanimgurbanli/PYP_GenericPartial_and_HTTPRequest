using PYP_GenericPartial_and_HTTPRequest.HttpClients;
using Refit;
using System.Text.Json;

namespace PYP_GenericPartial_and_HTTPRequest.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void AddRefitHttpClient<T>(this IServiceCollection service, string baseurl) where T : class
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            };

            var settings = new RefitSettings()
            {
                ContentSerializer = new SystemTextJsonContentSerializer(options)
            };

            service.AddRefitClient<T>(settings)
                        .ConfigureHttpClient(hc =>
                        {
                                hc.BaseAddress = new Uri(baseurl);
                        });

        }
    }
}
