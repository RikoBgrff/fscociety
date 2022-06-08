using BussinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EFCategoryRepository categoryRepository = new EFCategoryRepository();
        public CategoryManager(EFCategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void CategoryAdd(Category category)
        {
            categoryRepository.Insert(category);
        }

        public void CategoryRemove(Category category)
        {
            categoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            categoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return categoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return categoryRepository.GetAll();
        }
    }
}
