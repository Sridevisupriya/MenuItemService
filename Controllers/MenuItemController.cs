using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuItemService.Models;
using MenuItemService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MenuItemService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private readonly IMenuItemRepository _IMenuItemRepository;
        public MenuItemController(IMenuItemRepository Repo)
        {
            this._IMenuItemRepository = Repo;
        }

        [HttpGet]
        public IActionResult GetAllMenuItems()
        {
            try
            {

                IEnumerable<MenuItem> Vlist = _IMenuItemRepository.GetAll();
                return Ok(Vlist);
            }
            catch
            {

                return new NoContentResult();
            }

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var Vlist = _IMenuItemRepository.GetById(id);
                return new OkObjectResult(Vlist);
            }
            catch
            {
                return new NoContentResult();
            }

        }
    }
}
