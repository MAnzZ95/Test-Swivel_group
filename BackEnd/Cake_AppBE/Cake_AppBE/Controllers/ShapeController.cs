using Cake_AppBE.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cake_AppBE.Controllers
{
    [Route("api/shape")]
    [ApiController]
    public class ShapeController : ControllerBase
    {
        private readonly IShapeRepository _shapeRepository;

        public ShapeController(IShapeRepository shapeRepository)
        {
            _shapeRepository = shapeRepository;
        }

        [HttpGet]
        public async Task<ActionResult> getShapeAllShapes()
        {
            try
            {
                var shape = await _shapeRepository.GetAllShapes();

                if(shape.Count()==0)
                {
                    return NoContent();
                }
                return Ok(shape);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
