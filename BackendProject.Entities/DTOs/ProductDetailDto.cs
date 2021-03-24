using Core.Entities;
using Core.Entities.Abstract;

namespace BackendProject.Entities.DTOs
{
    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
    }
}
