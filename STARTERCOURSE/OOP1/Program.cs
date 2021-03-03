using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { ID = 2, CategoryID = 1, ProductName = "Leptop", UnitPrice = 4000, UnitsInStock = 3 };
            ProductManager productManager = new ProductManager();
            productManager.Topla2(3,6);

        }
    }
}
