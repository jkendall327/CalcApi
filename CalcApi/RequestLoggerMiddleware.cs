namespace CalcApi;

public class RequestLoggerMiddleware : IMiddleware
{
    private readonly ILogger<RequestLoggerMiddleware> _logger;

    public RequestLoggerMiddleware(ILogger<RequestLoggerMiddleware> logger)
    {
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        _logger.LogDebug("Logging request...");
        
        await next(context);
    }
}