using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using BackendProject.DataAccess.Abstract;
using BackendProject.Entities.Concrete;
using BackendProject.Entities.DTOs;

namespace BackendProject.DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        private readonly List<Product> _products;

        public InMemoryProductDal() : base()
        {
            _products = new List<Product>()
            {
                new Product() {ProductId =  1, CategoryId = 1, ProductName = "Cup", UnitPrice = 15, UnitsInStock = 15},
                new Product() {ProductId = 2, CategoryId = 1, ProductName = "Camera", UnitPrice = 500, UnitsInStock = 3},
                new Product() {ProductId = 3, CategoryId = 2, ProductName = "Phone", UnitPrice = 1500, UnitsInStock = 2},
                new Product() {ProductId = 4, CategoryId = 2, ProductName = "Keyboard", UnitPrice = 150, UnitsInStock = 65},
                new Product() {ProductId = 5, CategoryId = 2, ProductName = "Mouse", UnitPrice = 85, UnitsInStock = 1},
            };
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return filter == null ? _products : _products.Where(filter.Compile()).ToList();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return _products.FirstOrDefault(filter.Compile());
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var updatedProduct = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            var index = _products.IndexOf(updatedProduct);
            _products.Remove(updatedProduct);
            _products.Insert(index,product);
        }

        public void Delete(Product product)
        {
            var deletedProduct = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(deletedProduct);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
