using Cake_AppBE.IRepository;
using Cake_AppBE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cake_AppBE.Controllers
{
    [Route("api/cakesize")]
    [ApiController]
    public class SizeController : ControllerBase
    {
        private readonly ISizeRepository _sizeRepository;

        public SizeController(ISizeRepository sizeRepository)
        {
            _sizeRepository = sizeRepository;
        }

        [HttpGet]
        public async Task<ActionResult> getAllSizes()
        {
            try
            {
                var size = await _sizeRepository.GetAllSises();
                return Ok(size);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
