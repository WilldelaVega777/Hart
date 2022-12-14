//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Hart.Contracts.Services;
using Hart.Contracts.Repositories;


//--------------------------------------------------------------------------
// Namespace Section
//--------------------------------------------------------------------------
namespace Hart.Controllers
{
    //----------------------------------------------------------------------
    // Class Section
    //----------------------------------------------------------------------
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //------------------------------------------------------------------
        // Private Fields Section
        //------------------------------------------------------------------
        private readonly ILoggerManager _logger;
        private readonly IRepositoryManager _repository;


        //------------------------------------------------------------------
        // Constructor Method Section
        //------------------------------------------------------------------
        public ProductController(
            IRepositoryManager repository,
            ILoggerManager logger
        )
        {
            _logger = logger;
            _repository = repository;
        }

        //------------------------------------------------------------------
        // Controller Methods Section
        //------------------------------------------------------------------
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            _logger.LogInfo("Returning Products");
            var products = await _repository.Product.GetAllProductsAsync(false);
            return Ok(products);
        }
    }
}
