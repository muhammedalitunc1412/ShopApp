using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WEBUI.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        //[Display(Name = "Name", Prompt = "Enter product name")]

        //[Required(ErrorMessage ="Name Kısmı Zorunlu Alan")]
        //[StringLength(60,MinimumLength =5,ErrorMessage ="Name alanı 5 ile 10 karakter arası olmak zorundadır")]      
        public string Name { get; set; }

        [Required(ErrorMessage ="Url Kısmı Zorunlu Alan")]
        public string Url { get; set; }

        //[Required(ErrorMessage = "Price Kısmı Zorunlu Alan")]
        //[Range(1,10000, ErrorMessage = "Price alanı 1 ile 10000 sayısı arasında olmak zorundadır")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "Description Kısmı Zorunlu Alan")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Description alanı 5 ile 100 karakter arası olmak zorundadır")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Img Kısmı Zorunlu Alandır")]

        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }

        public List<Category> SelectedCategories { get; set; }
    }
}
