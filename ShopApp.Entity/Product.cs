﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entity
{
    public class Product
    {
        public bool IsHome { get; set; }

        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public double? Price { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public bool IsApproved { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
