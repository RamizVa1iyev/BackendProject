using BackendProject.Entities.Concrete;
using Core.DataAccess;

namespace BackendProject.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
