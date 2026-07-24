using Application.DTO.Football;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/football")]
    [ApiController]
    public class FootballPlayerController : ControllerBase
    {
        private readonly FootballPlayerService _footballPlayerService;
        List<string> _errorMessages = new List<String>();

        public FootballPlayerController(FootballPlayerService footballPlayerService)
        {
            _footballPlayerService = footballPlayerService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FootballPlayerDTO>>> GetFootballPlayers()
        {
            IEnumerable<FootballPlayerDTO> footballPlayersDTO = await _footballPlayerService.GetAllFootballPlayers();

            return Ok(footballPlayersDTO);
        }

        [HttpGet("name/{playerName}")]
        public async Task<ActionResult<FootballPlayerDTO>> FindFootballPlayerByName(string playerName)
        {
            var footballPlayerDTO = await _footballPlayerService.GetFootballPlayerByName(playerName);

            if (footballPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(footballPlayerDTO);
        }


        [HttpGet("country/{country}")]
        public async Task<ActionResult<FootballPlayerDTO>> FindFootballPlayerByCountry(string country)
        {
            var footballPlayerDTO = await _footballPlayerService.GetFootballPlayerByCountry(country);

            if (footballPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(footballPlayerDTO);
        }

        [HttpGet("game/{game}")]
        public async Task<ActionResult<FootballPlayerDTO>> FindFootballPlayerByGame(string game)
        {
            var footballPlayerDTO = await _footballPlayerService.GetFootballPlayersByGame(game);

            if (footballPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(footballPlayerDTO);
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<FootballPlayerDTO>>> Search([FromQuery] FootballPlayerFilterDTO filter)
        {
            var footballPlayerDTOs = await _footballPlayerService.GetFootballPlayersByFilter(filter);
            if (footballPlayerDTOs != null) return Ok(footballPlayerDTOs);
            _errorMessages.Add("Not Found");
            return BadRequest(new { Errors = _errorMessages });
        }


        
        [HttpPost]
        public async Task<ActionResult<FootballPlayerDTO>> PostFootballPlayer(CreateFootballPlayerDTO footballPlayerDTO)
        {
            FootballPlayerDTO createdFootballPlayerDTO =
                await _footballPlayerService.AddFootballPlayer(footballPlayerDTO, _errorMessages);


            if (createdFootballPlayerDTO != null)
            {
                return CreatedAtAction(nameof(FindFootballPlayerByName),
                    new { playerName = createdFootballPlayerDTO.PlayerName },
                    createdFootballPlayerDTO);
                return null;
            }
            else
            {
                return BadRequest();
            }

            return null;
        }


        
        [HttpPatch("id/{playerId}")]
        public async Task<ActionResult<FootballPlayerDTO>> UpdateFootballPlayer(Guid playerId, UpdateFootballPlayerDTO updateFootballPlayerDto)
        {
            FootballPlayerDTO footballPlayerDTO = await _footballPlayerService.UpdateFootballPlayer(playerId, updateFootballPlayerDto, _errorMessages);

            if (footballPlayerDTO != null)
            {
                return Ok(footballPlayerDTO);
            }
            else
            {
                return BadRequest(_errorMessages);
            }
        }
    }
}