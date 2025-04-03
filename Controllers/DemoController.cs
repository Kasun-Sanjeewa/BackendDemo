using BackendDemo.Models;
using BackendDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {

        private ItemServices _itemService;

        public DemoController()
        {
            _itemService = new ItemServices();
        }

        [HttpGet("{Id?}")]
        public IActionResult GetIem(int? Id)
        {
            
            var response = _itemService.AllItems();
            if (Id is null) return Ok(response);

            response = response.Where(t => t.ItemId == Id).ToList();
            return Ok(response);

        }

        
    }
}
