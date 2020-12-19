using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    class Order
    {
      

        public string Product { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Order(string product, string description, string image)
        {
            Product = product;
            Description = description;
            Image = image;
        }

    }


}
