using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManagerTest();
            //IoC
           // CategoryManagerTest();
        }

        private static void CategoryManagerTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductManagerTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine("**********************************************************************************************************");
                Console.WriteLine(" Product Name  : " + product.ProductName );
                Console.WriteLine(" Category Name : " + product.CategoryName);
                Console.WriteLine("     ");
               
            }
        }
    }
}
