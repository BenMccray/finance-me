[ApiController]
[Route("api/[controller]")]
[Authorize]
public class ExpensesController : ControllerBase
{
  [HttpGet]
  public IActionResult GetExpenses([FromQuery] ExpenseQueryParams query) => Ok();

  [HttpGet("{id}")]
  public IActionResult GetExpense(Guid id) => Ok();

  [HttpPost]
  public IActionResult CreateExpense(CreateExpenseDto dto) => Ok();

  [HttpPut("{id}")]
  public IActionResult UpdateExpense(Guid id, UpdateExpenseDto dto) => Ok();

  [HttpDelete("{id}")]
  public IActionResult DeleteExpense(Guid id) => Ok();
}
