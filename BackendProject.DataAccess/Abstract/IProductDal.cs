using System.Collections.Generic;
using BackendProject.Entities.Concrete;
using BackendProject.Entities.DTOs;
using Core.DataAccess;

namespace BackendProject.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        public List<ProductDetailDto> GetProductDetails();
    }
}
