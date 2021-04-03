using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WEBUI.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Name Kısmı Zorunlu Alandır")]
        [StringLength(25,MinimumLength =4,ErrorMessage ="Karakter Uzunluğu 4-25 Arası Olmak Zorundadır")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Url Kısmı Zorunlu Alandır")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "Karakter Uzunluğu 4-25 Arası Olmak Zorundadır")]
        public string Url { get; set; }

        public List<Product> Products { get; set; }

    }
}
