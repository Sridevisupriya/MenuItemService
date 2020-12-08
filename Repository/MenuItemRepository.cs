using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuItemService.Models;

namespace MenuItemService.Repository
{
    public class MenuItemRepository : IMenuItemRepository
    {
        public List<MenuItem> menu_list = new List<MenuItem>();

        public MenuItemRepository()
        {
            menu_list.Add(new MenuItem { MenuItem_Id = 1, Name = "French Fries",FreeDelivery=true, Price = 250 ,Active=false  });
            menu_list.Add(new MenuItem { MenuItem_Id = 2, Name = "Biryani", FreeDelivery = false, Price = 400, Active = true});
            menu_list.Add(new MenuItem { MenuItem_Id = 3, Name = "Salad", FreeDelivery = false, Price = 150, Active = false});
            menu_list.Add(new MenuItem { MenuItem_Id = 4, Name = "Chicken", FreeDelivery = true, Price = 350, Active = true});



        }


        public IEnumerable<MenuItem> GetAll()
        {
            return menu_list;
        }

        public MenuItem GetById(int menuItemId)
        {
            foreach (var item in menu_list)
            {
                if (item.MenuItem_Id == menuItemId)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
