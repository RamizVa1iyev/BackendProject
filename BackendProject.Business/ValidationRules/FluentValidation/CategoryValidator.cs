using BackendProject.Entities.Concrete;
using FluentValidation;

namespace BackendProject.Business.ValidationRules.FluentValidation
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName).NotNull();
            RuleFor(c => c.CategoryName).MinimumLength(3);
        }
    }
}
