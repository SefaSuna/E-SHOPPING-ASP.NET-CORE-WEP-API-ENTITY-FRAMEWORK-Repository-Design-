﻿using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class CartModel
    {
            public int CartId { get; set; }
            public List<CartItemModel> CartItems { get; set; }
            public int Total { get; set; }
    }
    public class CartItemModel
        {
            public int CartItemId { get; set; }
            public int ProductId { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public string ImageUrl { get; set; }
            public int Quantity { get; set; }
        }

    }

