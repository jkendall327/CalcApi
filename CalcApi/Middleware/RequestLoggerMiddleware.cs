using CalcApi.Data;

namespace CalcApi.Middleware;

public class RequestLoggerMiddleware : IMiddleware
{
    private readonly ILogger<RequestLoggerMiddleware> _logger;
    private readonly CalculatorContext _context;

    public RequestLoggerMiddleware(ILogger<RequestLoggerMiddleware> logger, CalculatorContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task InvokeAsync(HttpContext request, RequestDelegate next)
    {
        _logger.LogDebug("Request at path {Path}", request.Request.Path);

        var log = new RequestLog
        {
            Recieved = DateTime.Now,
            Details = request.Request.Path
        };
        
        _context.RequestLogs.Add(log);

        await _context.SaveChangesAsync();

        await next(request);
    }
}