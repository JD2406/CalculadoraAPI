using Microsoft.AspNetCore.Mvc;

namespace CalculadoraAPI.Controllers;

[ApiController]
[Route(template: "[controller]")]
public class CalculadoraControler : ControllerBase
{
    [HttpGet("sumar")]
    public ActionResult<object> Sumar([FromQuery] int a, [FromQuery] int b)
    {
        var result = new 
        {
            a = a,
            b = b,
            operacion = "sumar",
            resultado = a + b
        };
        return Ok(result);
    }

    [HttpGet("restar")]
    public ActionResult<object> Restar([FromQuery] int a, [FromQuery] int b)
    {
        var result = new 
        {
            a = a,
            b = b,
            operacion = "restar",
            resultado = a - b
        };
        return Ok(result);
    }

    [HttpGet("multiplicar")]
    public ActionResult<object> Multiplicar([FromQuery] int a, [FromQuery] int b)
    {
        var result = new 
        {
            a = a,
            b = b,
            operacion = "multiplicar",
            resultado = a * b
        };
        return Ok(result);
    }

    [HttpGet("dividir")]
    public ActionResult<object> Dividir([FromQuery] int a, [FromQuery] int b)
    {
        if (b == 0)
        {
            return BadRequest(new { error = "No se puede dividir por cero." });
        }
        var result = new 
        {
            a = a,
            b = b,
            operacion = "dividir",
            resultado = a / (double)b
        };
        return Ok(result);
    }
}
