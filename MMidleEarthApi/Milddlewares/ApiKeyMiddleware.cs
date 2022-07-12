namespace MMidleEarthApi.Milddlewares
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate _next;
        private const string ApiKey = "X-Api-Key";

        public ApiKeyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Headers.TryGetValue(ApiKey, out var extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Api Key was not provided!");
                return;
            }

            var appSetting = context.RequestServices.GetRequiredService<IConfiguration>();
            var apiKey = appSetting.GetValue<string>(ApiKey);

            if (!apiKey.Equals(extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("UnAuthorized!");
                return;
            }

            await _next(context);
        }

    }
}
