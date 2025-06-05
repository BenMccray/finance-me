[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
  [HttpGet("{id}")]
  [Authorize]
  public IActionResult GetUser(Guid id) => Ok();

  [HttpPut("{id}")]
  [Authorize(Roles = "Admin")]
  public IActionResult UpdateUser(Guid id, UpdateUserDto dto) => Ok();

  [HttpPatch("{id}/password")]
  [Authorize(Roles = "Admin")]
  public IActionResult ResetPassword(Guid id, ResetPasswordDto dto) => Ok();

  [HttpDelete("{id}")]
  [Authorize(Roles = "Admin")]
  public IActionResult DeleteUser(Guid id) => Ok();
}
