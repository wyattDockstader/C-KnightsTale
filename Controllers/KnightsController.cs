using C_KnightsTale.Services;
using Microsoft.AspNetCore.Mvc;

namespace C_KnightsTale.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class KnightsController : ControllerBase
  {
    private readonly KnightsService _ks;
    public KnightsController(KnightsService ks)
    {
      _ks = ks;
    }
  }
}