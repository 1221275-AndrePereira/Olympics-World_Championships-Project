using Application.DTO.Handball;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/handball")]
    [ApiController]
    public class HandballPlayerController : ControllerBase
    {
        private readonly HandballPlayerService _handballPlayerService;
        List<string> _errorMessages = new List<String>();

        public HandballPlayerController(HandballPlayerService handballPlayerService)
        {
            _handballPlayerService = handballPlayerService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HandballPlayerDTO>>> GetHandballPlayers()
        {
            IEnumerable<HandballPlayerDTO> handballPlayersDTO = await _handballPlayerService.GetAllHandballPlayers();

            return Ok(handballPlayersDTO);
        }

        [HttpGet("name/{playerName}")]
        public async Task<ActionResult<HandballPlayerDTO>> FindHandballPlayerByName(string playerName)
        {
            var handballPlayerDTO = await _handballPlayerService.GetHandballPlayerByName(playerName);

            if (handballPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(handballPlayerDTO);
        }


        [HttpGet("country/{country}")]
        public async Task<ActionResult<HandballPlayerDTO>> FindHandballPlayerByCountry(string country)
        {
            var handballPlayerDTO = await _handballPlayerService.GetHandballPlayerByCountry(country);

            if (handballPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(handballPlayerDTO);
        }

        [HttpGet("game/{game}")]
        public async Task<ActionResult<HandballPlayerDTO>> FindHandballPlayerByGame(string game)
        {
            var handballPlayerDTO = await _handballPlayerService.GetHandballPlayersByGame(game);

            if (handballPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(handballPlayerDTO);
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<HandballPlayerDTO>>> Search([FromQuery] HandballPlayerFilterDTO filter)
        {
            var handballPlayerDTOs = await _handballPlayerService.GetHandballPlayersByFilter(filter);
            if (handballPlayerDTOs != null) return Ok(handballPlayerDTOs);
            _errorMessages.Add("Not Found");
            return BadRequest(new { Errors = _errorMessages });
        }


        
        [HttpPost]
        public async Task<ActionResult<HandballPlayerDTO>> PostHandballPlayer(CreateHandballPlayerDTO handballPlayerDTO)
        {
            HandballPlayerDTO createdHandballPlayerDTO =
                await _handballPlayerService.AddHandballPlayer(handballPlayerDTO, _errorMessages);


            if (createdHandballPlayerDTO != null)
            {
                return CreatedAtAction(nameof(FindHandballPlayerByName),
                    new { playerName = createdHandballPlayerDTO.PlayerName },
                    createdHandballPlayerDTO);
                return null;
            }
            else
            {
                return BadRequest();
            }

            return null;
        }


        
        [HttpPatch("id/{playerId}")]
        public async Task<ActionResult<HandballPlayerDTO>> UpdateHandballPlayer(Guid playerId, UpdateHandballPlayerDTO updateHandballPlayerDto)
        {
            HandballPlayerDTO handballPlayerDTO = await _handballPlayerService.UpdateHandballPlayer(playerId, updateHandballPlayerDto, _errorMessages);

            if (handballPlayerDTO != null)
            {
                return Ok(handballPlayerDTO);
            }
            else
            {
                return BadRequest(_errorMessages);
            }
        }
    }
}