using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace my.planner.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlannerController : ControllerBase
    {
        private readonly ILogger<PlannerController> _logger;

        public PlannerController(ILogger<PlannerController> logger)
        {
            _logger = logger;
        }

        [HttpGet("getByPeriod")]
        public IActionResult GetByPeriod([FromRoute] DateTime startDate, [FromRoute] DateTime endDate)
        {
            try
            {
                return Ok("");
            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
        }
        
    }
}
