using Application.DTO.AmericanFootball;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/americanfootball")]
    [ApiController]
    public class AmericanFootballPlayerController : ControllerBase
    {
        private readonly AmericanFootballPlayerService _americanFootballPlayerService;
        List<string> _errorMessages = new List<String>();

        public AmericanFootballPlayerController(AmericanFootballPlayerService americanFootballPlayerService)
        {
            _americanFootballPlayerService = americanFootballPlayerService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AmericanFootballPlayerDTO>>> GetAmericanFootballPlayers()
        {
            IEnumerable<AmericanFootballPlayerDTO> americanFootballPlayersDTO = await _americanFootballPlayerService.GetAllAmericanFootballPlayers();

            return Ok(americanFootballPlayersDTO);
        }

        [HttpGet("name/{playerName}")]
        public async Task<ActionResult<AmericanFootballPlayerDTO>> FindAmericanFootballPlayerByName(string playerName)
        {
            var americanFootballPlayerDTO = await _americanFootballPlayerService.GetAmericanFootballPlayerByName(playerName);

            if (americanFootballPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(americanFootballPlayerDTO);
        }

        [HttpGet("game/{game}")]
        public async Task<ActionResult<AmericanFootballPlayerDTO>> FindAmericanFootballPlayerByGame(string game)
        {
            var americanFootballPlayerDTO = await _americanFootballPlayerService.GetAmericanFootballPlayersByGame(game);

            if (americanFootballPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(americanFootballPlayerDTO);
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<AmericanFootballPlayerDTO>>> Search([FromQuery] AmericanFootballPlayerFilterDTO filter)
        {
            var americanFootballPlayerDTOs = await _americanFootballPlayerService.GetAmericanFootballPlayersByFilter(filter);
            if (americanFootballPlayerDTOs != null) return Ok(americanFootballPlayerDTOs);
            _errorMessages.Add("Not Found");
            return BadRequest(new { Errors = _errorMessages });
        }


        
        [HttpPost]
        public async Task<ActionResult<AmericanFootballPlayerDTO>> PostAmericanFootballPlayer(CreateAmericanFootballPlayerDTO americanFootballPlayerDTO)
        {
            AmericanFootballPlayerDTO createdAmericanFootballPlayerDTO =
                await _americanFootballPlayerService.AddAmericanFootballPlayer(americanFootballPlayerDTO, _errorMessages);


            if (createdAmericanFootballPlayerDTO != null)
            {
                return CreatedAtAction(nameof(FindAmericanFootballPlayerByName),
                    new { playerName = createdAmericanFootballPlayerDTO.PlayerName },
                    createdAmericanFootballPlayerDTO);
                return null;
            }
            else
            {
                return BadRequest();
            }

            return null;
        }


        
        [HttpPatch("id/{playerId}")]
        public async Task<ActionResult<AmericanFootballPlayerDTO>> UpdateAmericanFootballPlayer(Guid playerId, UpdateAmericanFootballPlayerDTO updateAmericanFootballPlayerDto)
        {
            AmericanFootballPlayerDTO americanFootballPlayerDTO = await _americanFootballPlayerService.UpdateAmericanFootballPlayer(playerId, updateAmericanFootballPlayerDto, _errorMessages);

            if (americanFootballPlayerDTO != null)
            {
                return Ok(americanFootballPlayerDTO);
            }
            else
            {
                return BadRequest(_errorMessages);
            }
        }
    }
}