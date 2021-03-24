using System.Collections.Generic;
using System.Linq;
using BackendProject.DataAccess.Abstract;
using BackendProject.DataAccess.Concrete.EntityFramework.Contexts;
using BackendProject.Entities.Concrete;
using BackendProject.Entities.DTOs;
using Core.DataAccess.EntityFramework;

namespace BackendProject.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using var context = new NorthwindContext();
            var result = from p in context.Products
                join c in context.Categories on p.CategoryId equals c.CategoryId
                select new ProductDetailDto()
                {
                    ProductName = p.ProductName,
                    CategoryName = c.CategoryName,
                    UnitsInStock = p.UnitsInStock,
                    ProductId = p.ProductId
                };
            return result.ToList();
        }
    }
}
