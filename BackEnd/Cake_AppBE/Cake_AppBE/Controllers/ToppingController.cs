using Cake_AppBE.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cake_AppBE.Controllers
{
    [Route("api/topping")]
    [ApiController]
    public class ToppingController : ControllerBase
    {
        private readonly IToppingRepository _toppingRepository;

        public ToppingController(IToppingRepository toppingRepository)
        {
            _toppingRepository = toppingRepository;
        }

        [HttpGet]
        public async Task<ActionResult> getAllToppings()
        {
            try
            {
                var topping = await _toppingRepository.GetAllToppings();
                return Ok(topping);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
