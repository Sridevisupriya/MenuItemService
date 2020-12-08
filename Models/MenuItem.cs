using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemService.Models
{
    public class MenuItem
    {
        public int MenuItem_Id { get; set; }
        public string Name { get; set; }
        public Boolean FreeDelivery { get; set; }
        public double Price { get; set; }
        public Boolean Active { get; set; }

    }
}
