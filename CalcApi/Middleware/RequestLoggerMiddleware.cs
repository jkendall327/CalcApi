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
        _logger.LogDebug("Logging request...");
        
        // AddAsync adds no benefit.
        // _context.RequestLogs.Add();

        await _context.SaveChangesAsync();

        await next(request);
    }
}