using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
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
        readonly ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryRepository)
        {
            this.categoryDal = categoryRepository;
        }

        public void CategoryAdd(Category category)
        {
            categoryDal.Insert(category);
        }

        public void CategoryRemove(Category category)
        {
            categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            categoryDal.Update(category);
        }

        public Category GetById(int id)
        {
            return categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return categoryDal.GetAll();
        }
    }
}
