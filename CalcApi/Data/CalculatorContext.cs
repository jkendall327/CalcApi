using Microsoft.EntityFrameworkCore;

namespace CalcApi.Data;

public class CalculatorContext : DbContext
{
    public required DbSet<RequestLog> RequestLogs { get; set; }

    public CalculatorContext(DbContextOptions<CalculatorContext> options) : base(options)
    {
        
    }
}