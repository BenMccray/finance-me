[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
  [HttpPost("register")]
  public IActionResult Register(RegisterDto dto) => Ok();

  [HttpPost("login")]
  public IActionResult Login(LoginDto dto) => Ok();

  [HttpPost("logout")]
  public IActionResult Logout() => Ok();

  [HttpGet("me")]
  [Authorize]
  public IActionResult GetCurrentUser() => Ok();

  [HttpPatch("password")]
  public IActionResult ChangePassword(ChangePasswordDto dto) => Ok();
}