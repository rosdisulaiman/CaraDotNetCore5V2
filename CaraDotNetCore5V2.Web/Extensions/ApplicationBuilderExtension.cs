using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CaraDotNetCore5V2.Web.Extensions
{
    public static class ApplicationBuilderExtension
    {
        public static void UseMultiLingualFeature(this IApplicationBuilder app)
        {
            app.UseRequestLocalization(app.ApplicationServices.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);
        }

        public static void ConfigureSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "CaraDotNetCore5V1.Web");
                options.RoutePrefix = "swagger";
                options.DisplayRequestDuration();
            });
        }
    }
}