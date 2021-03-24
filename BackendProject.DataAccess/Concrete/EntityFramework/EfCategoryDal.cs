using BackendProject.DataAccess.Abstract;
using BackendProject.DataAccess.Concrete.EntityFramework.Contexts;
using BackendProject.Entities.Concrete;
using Core.DataAccess.EntityFramework;

namespace BackendProject.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
    }
}
