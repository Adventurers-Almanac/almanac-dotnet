using AdventurersAlmanac.Domain.Dtos;
using AdventurersAlmanac.Handlers.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdventurersAlmanac.Controllers
{
    [ApiController]
    [Route("api/almanac")]
    public class AlmanacController : ControllerBase
    {
        /// <summary>
        /// Creates a new almanac using the specified command.
        /// </summary>
        /// <param name="command">The command containing the information for creating the almanac.</param>
        /// <returns>An <see cref="IActionResult"/> representing the result of the operation.</returns>
        [HttpPost("CreateNewAlmanac")]
        public async Task<IActionResult> CreateNewAlmanac([FromBody] CreateNewAlmanacCommand command)
        {
            CreateNewAlmanacCommandHandler handler = new CreateNewAlmanacCommandHandler();

            await handler.Handle(command, CancellationToken.None);

            return Ok();
        }
    }
}