using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3C__Product_maintenence
{
    public class ProductList : List<Product>
    {
        public new void Add(Product product) => base.Add(product);

        public void LoadFromDataBase()
        {
            base.Add(new Book("Java", "Murach's Java 8th edition", 59.5m, "Murach"));
            base.Add(new Software("ABC", "New Software Product", 55.9m, "5.2"));
            base.Add(new Book("Book 1", "New Book Product", 67m, "Tom"));
        }
    }
}
