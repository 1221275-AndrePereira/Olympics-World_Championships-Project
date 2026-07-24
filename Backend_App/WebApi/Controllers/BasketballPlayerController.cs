using Application.DTO.Basketball;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/basketball")]
    [ApiController]
    public class BasketballPlayerController : ControllerBase
    {
        private readonly BasketballPlayerService _basketballPlayerService;
        List<string> _errorMessages = new List<String>();

        public BasketballPlayerController(BasketballPlayerService basketballPlayerService)
        {
            _basketballPlayerService = basketballPlayerService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasketballPlayerDTO>>> GetBasketballPlayers()
        {
            IEnumerable<BasketballPlayerDTO> basketballPlayersDTO = await _basketballPlayerService.GetAllBasketballPlayers();

            return Ok(basketballPlayersDTO);
        }

        [HttpGet("name/{playerName}")]
        public async Task<ActionResult<BasketballPlayerDTO>> FindBasketballPlayerByName(string playerName)
        {
            var basketballPlayerDTO = await _basketballPlayerService.GetBasketballPlayerByName(playerName);

            if (basketballPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(basketballPlayerDTO);
        }


        [HttpGet("country/{country}")]
        public async Task<ActionResult<BasketballPlayerDTO>> FindBasketballPlayerByCountry(string country)
        {
            var basketballPlayerDTO = await _basketballPlayerService.GetBasketballPlayerByCountry(country);

            if (basketballPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(basketballPlayerDTO);
        }

        [HttpGet("game/{game}")]
        public async Task<ActionResult<BasketballPlayerDTO>> FindBasketballPlayerByGame(string game)
        {
            var basketballPlayerDTO = await _basketballPlayerService.GetBasketballPlayersByGame(game);

            if (basketballPlayerDTO == null)
            {
                return NotFound();
            }

            return Ok(basketballPlayerDTO);
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<BasketballPlayerDTO>>> Search([FromQuery] BasketballPlayerFilterDTO filter)
        {
            var basketballPlayerDTOs = await _basketballPlayerService.GetBasketballPlayersByFilter(filter);
            if (basketballPlayerDTOs != null) return Ok(basketballPlayerDTOs);
            _errorMessages.Add("Not Found");
            return BadRequest(new { Errors = _errorMessages });
        }


        
        [HttpPost]
        public async Task<ActionResult<BasketballPlayerDTO>> PostBasketballPlayer(CreateBasketballPlayerDTO basketballPlayerDTO)
        {
            BasketballPlayerDTO createdBasketballPlayerDTO =
                await _basketballPlayerService.AddBasketballPlayer(basketballPlayerDTO, _errorMessages);


            if (createdBasketballPlayerDTO != null)
            {
                return CreatedAtAction(nameof(FindBasketballPlayerByName),
                    new { playerName = createdBasketballPlayerDTO.PlayerName },
                    createdBasketballPlayerDTO);
                return null;
            }
            else
            {
                return BadRequest();
            }

            return null;
        }


        
        [HttpPatch("id/{playerId}")]
        public async Task<ActionResult<BasketballPlayerDTO>> UpdateBasketballPlayer(Guid playerId, UpdateBasketballPlayerDTO updateBasketballPlayerDto)
        {
            BasketballPlayerDTO basketballPlayerDTO = await _basketballPlayerService.UpdateBasketballPlayer(playerId, updateBasketballPlayerDto, _errorMessages);

            if (basketballPlayerDTO != null)
            {
                return Ok(basketballPlayerDTO);
            }
            else
            {
                return BadRequest(_errorMessages);
            }
        }
    }
}