using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoCSharp.Models
{
    public class Sale
    {
        public Sale(int id, string product, decimal price, DateTime date)
        {
            Id = id;
            Product = product;
            Price = price;
            Date = date;
        }

        public int Id { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

    }
}