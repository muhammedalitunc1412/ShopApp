using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using ShopApp.Entity;
using ShopApp.WEBUI.Models;

namespace ShopApp.WEBUI.Controllers
{
    public class ShopController : Controller
    {
       
        private IProductService _productService;

        public ShopController(IProductService productService)
        {
            this._productService = productService;
        }

        public IActionResult List(string category,int page=1)
        {
            const int pageSize = 6;
            var productViewModel = new ProductListViewModel()
            {
                PageInfo=new PageInfo()
                {
                    TotalItems=_productService.GetCountByCategory(category),
                    CurrentPage=page,
                    ItemsPerPage=pageSize,
                    CurrentCategory=category
                },

                Products = _productService.GetProductsByCategory(category,page,pageSize)
            };

            return View(productViewModel);
        }


        // GET: Shop/Details/5
        public IActionResult Details(string url)
        {
            if (url == null)
            {
                return NotFound();
            }
            Product product = _productService.GetProductDetails(url);

            if (product == null)
            {
                return NotFound();
            }
            return View(new ProductDetailModel
            {
                Product = product,
                Categories = product.ProductCategories.Select(i => i.Category).ToList()
            });
        }

        public IActionResult Search(string q)
        {
         
            var productViewModel = new ProductListViewModel()
            {
                Products = _productService.GetSearchResult(q)
            };

            return View(productViewModel);
        }




    }
}