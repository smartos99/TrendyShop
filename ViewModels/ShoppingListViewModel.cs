﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrendyShop.Models;

namespace TrendyShop.ViewModels
{
    public class ShoppingListViewModel
    {
        public string Id { get; set; }

        public string ArticleId { get; set; }
        public Article Article { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }

        public int TotalPrice { get { return Amount * Price; } }


    }
}
