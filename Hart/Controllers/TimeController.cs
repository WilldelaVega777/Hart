//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
using Microsoft.AspNetCore.Mvc;
using Hart.Contracts.Services;


//--------------------------------------------------------------------------
// Namespace Section
//--------------------------------------------------------------------------
namespace Hart.Controllers
{
    //----------------------------------------------------------------------
    // Class Section
    //----------------------------------------------------------------------
    [ApiController]
    [Route("api/[controller]")]
    public class TimeController : ControllerBase
    {
        //------------------------------------------------------------------
        // Private Fields Section
        //------------------------------------------------------------------
        private readonly ILoggerManager _logger;


        //------------------------------------------------------------------
        // Constructor Method Section
        //------------------------------------------------------------------
        public TimeController(
            ILoggerManager logger
        )
        {
            _logger = logger;
        }


        //------------------------------------------------------------------
        // Controller Methods Section
        //------------------------------------------------------------------
        [HttpGet(Name = "start")]
        public IActionResult Start()
        {
            var retVal = new { time = DateTime.Now.ToString() };
            return Ok( retVal );
        }
    }
}