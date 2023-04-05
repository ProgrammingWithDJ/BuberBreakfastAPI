using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Contracts.BuberBreakfast;

namespace BuberBreakfast.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class BreakfastController : ControllerBase
    {

        [HttpPost()]
        public IActionResult CreateBreakfast(CreateBreakFastRequest createBreakFastRequest)
        {
            return Ok(createBreakFastRequest);
        }

        [HttpGet("{Id:guid}")]
        public IActionResult GetBreakfast(Guid id)
        {
            return Ok(id);
        }

        [HttpPut("{Id:guid}")]
        public IActionResult UpdateBreakfast(Guid Id, UpsertBreakfastRequest updateBreakFastRequest)
        {
            return Ok(updateBreakFastRequest);
        }

        [HttpDelete("{Id:guid}")]
        public IActionResult DeleteSBreakfast(Guid id)
        {
            return Ok(id);
        }
    }
}
