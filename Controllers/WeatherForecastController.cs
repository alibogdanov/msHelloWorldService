using Microsoft.AspNetCore.Mvc;

namespace msHelloWorldService.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get()
    {
        return "Hello World from .NET Microservice";
    }
}
