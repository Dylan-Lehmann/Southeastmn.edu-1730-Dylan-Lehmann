using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3C__Product_maintenence
{
    public class Product
    {
        public string? Code { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }

        public Product(string? code, string? description, decimal price) =>
            (Code, Description, Price) = (code, description, price);

        public override string ToString() => $"{Code}/t${Price.ToString("c")}/t{Description}";
    }

}
