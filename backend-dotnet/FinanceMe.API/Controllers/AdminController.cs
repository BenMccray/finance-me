[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = "Admin")]
public class AdminController : ControllerBase
{
  [HttpGet("users")]
  public IActionResult ListUsers([FromQuery] UserSearchParams query) => Ok();

  [HttpGet("users/{id}")]
  public IActionResult GetUserById(Guid id) => Ok();

  [HttpPatch("users/{id}/role")]
  public IActionResult UpdateUserRole(Guid id, RoleUpdateDto dto) => Ok();
}
