using Core.Entities;
using Core.Entities.Abstract;

namespace BackendProject.Entities.Concrete
{
    public class Customer:IEntity
    {
        public string CustomerId { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
    }
}
