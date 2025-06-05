[ApiController]
[Route("api/[controller]")]
[Authorize]
public class AnalyticsController : ControllerBase
{
  [HttpGet("summary")]
  public IActionResult GetSummary([FromQuery] DateRangeQuery dto) => Ok();

  [HttpGet("forecast")]
  public IActionResult GetForecast() => Ok();

  [HttpGet("compare")]
  public IActionResult ComparePeriods(ComparePeriodDto dto) => Ok();
}
