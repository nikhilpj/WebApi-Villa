using Villa.Models;
using Microsoft.AspNetCore.Mvc;



namespace Villa.Controllers
{
    [Route("api/VillaApi")]
    [ApiController]
    public class VillaApiController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaItem> GetVillas()
        {
            return new List<VillaItem>
            {
                new VillaItem{Id = 1, Name ="Pool View"}
            };
        }
    }
}
