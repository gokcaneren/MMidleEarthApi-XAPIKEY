using Microsoft.AspNetCore.Diagnostics;
using MiddleEarth.Core.DTOs.Respons;
using MiddleEarth.Service.Exceptions;
using System.Text.Json;

namespace MMidleEarthApi.Milddlewares
{
    public static class UseCustomExceptionHandler
    {

        public static void UseCustomException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.ContentType = "application/json";

                    var exceptionFeature = context.Features.Get<IExceptionHandlerFeature>();

                    var statusCode = exceptionFeature.Error switch
                    {
                        ClientSideException => 400,
                        NotFoundException => 404,
                        _ => 500
                    };
                    context.Response.StatusCode = statusCode;
                    var response = CustomResponsDto<NoContentDto>.Fail(statusCode, exceptionFeature.Error.Message);

                    await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                });
            });
        }

    }
}
