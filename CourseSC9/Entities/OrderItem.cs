﻿using System.Globalization;

namespace CourseSC9.Entities
{
    class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem(Product product, int quantity, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
