using Cake_AppBE.IRepository;
using Cake_AppBE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cake_AppBE.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }


        [HttpGet("{id}",Name="orderbyid")]
        public async Task<ActionResult> getOrderbyId(int id)
        {
            try
            {
                var order = await _orderRepository.GetOrderById(id);
                if(order == null)
                {
                    return NotFound();
                }
                return Ok(order);
            }
            catch(Exception ex)
            {
                return StatusCode(500,ex.Message);
            }

        }
        [HttpPost]
        public async Task<ActionResult<Order>> saveOrder([FromBody]Order order)
        {
            try
            {
                if(order == null || !ModelState.IsValid)
                {
                    return BadRequest("Invalid State");
                }
                else
                {
                    var ord = await _orderRepository.AddOrder(order);
                    return ord;
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        

    }
}
