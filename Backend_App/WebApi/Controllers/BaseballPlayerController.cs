using Application.DTO.Baseball;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/baseball")]
    [ApiController]
    public class BaseballPlayerController : ControllerBase
    {
        private readonly BaseballPlayerService _baseballPlayerService;
        List<string> _errorMessages = new List<String>();

        public BaseballPlayerController(BaseballPlayerService baseballPlayerService)
        {
            _baseballPlayerService = baseballPlayerService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BaseballPlayerDTO>>> GetBaseballPlayers()
        {
            IEnumerable<BaseballPlayerDTO> baseballPlayersDTO = await _baseballPlayerService.GetAllBaseballPlayers();

            return Ok(baseballPlayersDTO);
        }

        [HttpGet("name/{playerName}")]
        public async Task<ActionResult<BaseballPlayerDTO>> FindBaseballPlayerByName(string playerName)
        {
            var baseballPlayerDTO = await _baseballPlayerService.GetBaseballPlayerByName(playerName);

            if (baseballPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(baseballPlayerDTO);
        }


        [HttpGet("country/{country}")]
        public async Task<ActionResult<BaseballPlayerDTO>> FindBaseballPlayerByCountry(string country)
        {
            var baseballPlayerDTO = await _baseballPlayerService.GetBaseballPlayerByCountry(country);

            if (baseballPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(baseballPlayerDTO);
        }

        [HttpGet("game/{game}")]
        public async Task<ActionResult<BaseballPlayerDTO>> FindBaseballPlayerByGame(string game)
        {
            var baseballPlayerDTO = await _baseballPlayerService.GetBaseballPlayersByGame(game);

            if (baseballPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(baseballPlayerDTO);
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<BaseballPlayerDTO>>> Search([FromQuery] BaseballPlayerFilterDTO filter)
        {
            var baseballPlayerDTOs = await _baseballPlayerService.GetBaseballPlayersByFilter(filter);
            if (baseballPlayerDTOs != null) return Ok(baseballPlayerDTOs);
            _errorMessages.Add("Not Found");
            return BadRequest(new { Errors = _errorMessages });
        }


        
        [HttpPost]
        public async Task<ActionResult<BaseballPlayerDTO>> PostBaseballPlayer(CreateBaseballPlayerDTO baseballPlayerDTO)
        {
            BaseballPlayerDTO createdBaseballPlayerDTO =
                await _baseballPlayerService.AddBaseballPlayer(baseballPlayerDTO, _errorMessages);


            if (createdBaseballPlayerDTO != null)
            {
                return CreatedAtAction(nameof(FindBaseballPlayerByName),
                    new { playerName = createdBaseballPlayerDTO.PlayerName },
                    createdBaseballPlayerDTO);
                return null;
            }
            else
            {
                return BadRequest();
            }

            return null;
        }


        
        [HttpPatch("id/{playerId}")]
        public async Task<ActionResult<BaseballPlayerDTO>> UpdateBaseballPlayer(Guid playerId, UpdateBaseballPlayerDTO updateBaseballPlayerDto)
        {
            BaseballPlayerDTO baseballPlayerDTO = await _baseballPlayerService.UpdateBaseballPlayer(playerId, updateBaseballPlayerDto, _errorMessages);

            if (baseballPlayerDTO != null)
            {
                return Ok(baseballPlayerDTO);
            }
            else
            {
                return BadRequest(_errorMessages);
            }
        }
    }
}