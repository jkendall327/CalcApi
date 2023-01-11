using CalcApi.Data;
using CalcApi.Middleware;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<RequestLoggerMiddleware>();
builder.Services.AddCalculator();

var connectionString = builder.Configuration.GetConnectionString(nameof(CalculatorContext));

builder.Services.AddDbContext<CalculatorContext>(c =>
{
    c.UseSqlite(connectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseMiddleware<RequestLoggerMiddleware>();

app.MapControllers();
app.Run();