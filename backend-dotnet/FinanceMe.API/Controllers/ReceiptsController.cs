[ApiController]
[Route("api/[controller]")]
[Authorize]
public class ReceiptsController : ControllerBase
{
  [HttpGet]
  public IActionResult GetReceipts() => Ok();

  [HttpGet("{id}")]
  public IActionResult GetReceipt(Guid id) => Ok();

  [HttpPost("upload")]
  public IActionResult UploadReceipt(IFormFile file) => Ok();

  [HttpPost("{id}/confirm")]
  public IActionResult ConfirmReceipt(Guid id) => Ok();

  [HttpDelete("{id}")]
  public IActionResult DeleteReceipt(Guid id) => Ok();
}
