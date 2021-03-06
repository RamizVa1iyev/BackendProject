using System.Collections.Generic;
using BackendProject.Entities.Concrete;
using Core.Utilities.Results;

namespace BackendProject.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int categoryId);
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);
    }
}
