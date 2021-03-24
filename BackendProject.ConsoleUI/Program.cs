using System;
using BackendProject.Business.Concrete;
using BackendProject.DataAccess.Concrete.EntityFramework;

namespace BackendProject.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            var categoryManager = new CategoryManager(new EfCategoryDal());
            var categories = categoryManager.GetAll();
            foreach (var category in categories.Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            var productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var productDetails = productManager.GetProductDetails();
            foreach (var productDetail in productDetails.Data)
            {
                Console.WriteLine("Product Name: {0} , Category Name: {1}",productDetail.ProductName,productDetail.CategoryName);
            }
        }
    }
}
