using Core.Entities;
using Core.Entities.Abstract;

namespace BackendProject.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
