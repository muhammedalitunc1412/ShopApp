using ShopApp.Entity;
using System.Collections.Generic;

namespace ShopApp.WEBUI.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}