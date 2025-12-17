using Estoque.Application.Validators;
using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;
using FluentValidation;

namespace Estoque.Application.Services
{
    public class CategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly CategoryValidator _validator;

        public CategoryService(ICategoryRepository categoryRepository, CategoryValidator validator)
        {
            _categoryRepository = categoryRepository;
            _validator = validator;
        }

        public void Register(Category category)
        {
            var validationResult = _validator.Validate(category);
            if (!validationResult.IsValid)
            {
                throw new Exception(validationResult.Errors.FirstOrDefault()?.ErrorMessage);
            }

            if (category.Id > 0)
            {
                _categoryRepository.Update(category);
            }
            else
            {
                _categoryRepository.Insert(category);
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryRepository.Select();
        }
    }
}
