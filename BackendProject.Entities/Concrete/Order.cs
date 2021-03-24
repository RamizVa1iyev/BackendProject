using System;
using Core.Entities;
using Core.Entities.Abstract;

namespace BackendProject.Entities.Concrete
{
    public class Order:IEntity
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderTime { get; set; }
        public string ShipCity { get; set; }
    }
}
