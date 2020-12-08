using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuItemService.Models;

namespace MenuItemService.Repository
{
   public interface IMenuItemRepository
    {
        IEnumerable<MenuItem> GetAll();
        MenuItem GetById(int menuItemId);
    }
}
