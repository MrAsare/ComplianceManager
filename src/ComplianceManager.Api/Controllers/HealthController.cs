using Microsoft.AspNetCore.Mvc;

namespace ComplianceManager.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() =>
        Ok(new { status = "healthy", service = "ComplianceManager.Api" });
}
