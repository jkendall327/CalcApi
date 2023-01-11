using CalcApi.Core;
using Microsoft.AspNetCore.Mvc;
using OneOf;

namespace CalcApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculationController : ControllerBase
{
    private readonly ICalculator _calculator;

    public CalculationController(ICalculator calculator)
    {
        _calculator = calculator;
    }
    
    [HttpGet("add")]
    public IActionResult Add(int x, int y)
    {
        var result = _calculator.Add(x, y);
        
        return ToActionResult(result);
    }
    
    [HttpGet("subtract")]
    public IActionResult Subtract(int x, int y)
    {
        var result = _calculator.Subtract(x, y);
        
        return ToActionResult(result);
    }
    
    [HttpGet("multiply")]
    public IActionResult Multiply(int x, int y)
    {
        var result = _calculator.Multiply(x, y);
        
        return ToActionResult(result);
    }
    
    [HttpGet("divide")]
    public IActionResult Divide(int x, int y)
    {
        var result = _calculator.Divide(x, y);
        
        return ToActionResult(result);
    }

    private ObjectResult ToActionResult(OneOf<int, Error> result)
    {
        return result.Match(
            value => Ok(value), 
            error => Problem(error.Message));
    }
}