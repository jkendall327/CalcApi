using CalcApi.Core;
using Microsoft.AspNetCore.Mvc;

namespace CalcApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculationController : ControllerBase
{
    private readonly ILogger<CalculationController> _logger;
    private readonly ICalculator _calculator;

    public CalculationController(ILogger<CalculationController> logger, ICalculator calculator)
    {
        _logger = logger;
        _calculator = calculator;
    }

    [HttpGet(Name = "Add")]
    public IActionResult Get(int x, int y)
    {
        var result = _calculator.Add(x, y);
        
        return result.Match(i => Ok(i), error => Problem(error.Message));
    }
}