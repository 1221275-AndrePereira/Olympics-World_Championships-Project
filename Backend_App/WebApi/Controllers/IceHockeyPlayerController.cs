using Application.DTO.IceHockey;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/icehockey")]
    [ApiController]
    public class IceHockeyPlayerController : ControllerBase
    {
        private readonly IceHockeyPlayerService _iceHockeyPlayerService;
        List<string> _errorMessages = new List<String>();

        public IceHockeyPlayerController(IceHockeyPlayerService iceHockeyPlayerService)
        {
            _iceHockeyPlayerService = iceHockeyPlayerService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<IceHockeyPlayerDTO>>> GetIceHockeyPlayers()
        {
            IEnumerable<IceHockeyPlayerDTO> iceHockeyPlayersDTO = await _iceHockeyPlayerService.GetAllIceHockeyPlayers();

            return Ok(iceHockeyPlayersDTO);
        }

        [HttpGet("name/{playerName}")]
        public async Task<ActionResult<IceHockeyPlayerDTO>> FindIceHockeyPlayerByName(string playerName)
        {
            var iceHockeyPlayerDTO = await _iceHockeyPlayerService.GetIceHockeyPlayerByName(playerName);

            if (iceHockeyPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(iceHockeyPlayerDTO);
        }


        [HttpGet("country/{country}")]
        public async Task<ActionResult<IceHockeyPlayerDTO>> FindIceHockeyPlayerByCountry(string country)
        {
            var iceHockeyPlayerDTO = await _iceHockeyPlayerService.GetIceHockeyPlayerByCountry(country);

            if (iceHockeyPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(iceHockeyPlayerDTO);
        }

        [HttpGet("game/{game}")]
        public async Task<ActionResult<IceHockeyPlayerDTO>> FindIceHockeyPlayerByGame(string game)
        {
            var iceHockeyPlayerDTO = await _iceHockeyPlayerService.GetIceHockeyPlayersByGame(game);

            if (iceHockeyPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(iceHockeyPlayerDTO);
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<IceHockeyPlayerDTO>>> Search([FromQuery] IceHockeyPlayerFilterDTO filter)
        {
            var iceHockeyPlayerDTOs = await _iceHockeyPlayerService.GetIceHockeyPlayersByFilter(filter);
            if (iceHockeyPlayerDTOs != null) return Ok(iceHockeyPlayerDTOs);
            _errorMessages.Add("Not Found");
            return BadRequest(new { Errors = _errorMessages });
        }


        
        [HttpPost]
        public async Task<ActionResult<IceHockeyPlayerDTO>> PostIceHockeyPlayer(CreateIceHockeyPlayerDTO iceHockeyPlayerDTO)
        {
            IceHockeyPlayerDTO createdIceHockeyPlayerDTO =
                await _iceHockeyPlayerService.AddIceHockeyPlayer(iceHockeyPlayerDTO, _errorMessages);


            if (createdIceHockeyPlayerDTO != null)
            {
                return CreatedAtAction(nameof(FindIceHockeyPlayerByName),
                    new { playerName = createdIceHockeyPlayerDTO.PlayerName },
                    createdIceHockeyPlayerDTO);
                return null;
            }
            else
            {
                return BadRequest();
            }

            return null;
        }


        
        [HttpPatch("id/{playerId}")]
        public async Task<ActionResult<IceHockeyPlayerDTO>> UpdateIceHockeyPlayer(Guid playerId, UpdateIceHockeyPlayerDTO updateIceHockeyPlayerDto)
        {
            IceHockeyPlayerDTO iceHockeyPlayerDTO = await _iceHockeyPlayerService.UpdateIceHockeyPlayer(playerId, updateIceHockeyPlayerDto, _errorMessages);

            if (iceHockeyPlayerDTO != null)
            {
                return Ok(iceHockeyPlayerDTO);
            }
            else
            {
                return BadRequest(_errorMessages);
            }
        }
    }
}