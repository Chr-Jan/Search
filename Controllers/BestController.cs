using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Search.Data;
using Search.Models;
using System.Runtime.CompilerServices;

namespace Search.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BestController : ControllerBase
    {


        [HttpGet("GetAllHumans")]
        public ActionResult<IEnumerable<Human>> GetAllDate()
        {
            var humans = SeedData.GetHumans();
            return Ok(humans);
        }

        [HttpGet("Search")]
        public ActionResult<IEnumerable<Human>> Search(string searchTerm)
        {
            var humans = SeedData.GetHumans();

            if (string.IsNullOrEmpty(searchTerm))
            {
                return Ok(humans);
            }
            else
            {
                var matchingHumans = humans
                    .Where(h => h.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                return Ok(matchingHumans);
            }
        }
    }
}
