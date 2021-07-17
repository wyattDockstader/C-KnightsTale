using C_KnightsTale.Sevices;
using Microsoft.AspNetCore.Mvc;

namespace C_KnightsTale.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CastlesController : ControllerBase
  {
    private readonly CastlesService _cs;
    public CastlesController(CastlesService cs)
    {
      _cs = cs;
    }

  }
}