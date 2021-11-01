using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using BusinessLogic.Services.Pizza;
using Microsoft.AspNetCore.Mvc;
using ReactPizza.Api.Controllers.Pizza.Mappers;

namespace ReactPizza.Api.Controllers.Pizza
{
    [Route("api/pizzas")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaService _pizzaService;

        private readonly IPizzaControllerRequestsMapper _requestsMapper;
        private readonly IPizzaControllerResponsesMapper _responsesMapper;

        public PizzaController(
            IPizzaService pizzaService,
            IPizzaControllerRequestsMapper requestsMapper,
            IPizzaControllerResponsesMapper responsesMapper)
        {
            _pizzaService = pizzaService;
            _requestsMapper = requestsMapper;
            _responsesMapper = responsesMapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPizzas(
            [FromQuery] [Required] int page,
            [FromQuery] [Required] int size)
        {
            var command = _requestsMapper.ToCommand(page, size);

            var pizzas = await _pizzaService.GetPizzas(command);

            var response = _responsesMapper.ToResponse(pizzas);
            return Ok(response);
        }

        [HttpGet("categories")]
        public IActionResult GetPizzaCategories()
        {
            var categories = _pizzaService.GetPizzaCategories();

            var response = _responsesMapper.ToResponse(categories);
            return Ok(response);
        }
    }
}
