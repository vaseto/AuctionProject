using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Database;

namespace BussinessLayer
{
    public class CategoryController : AController<Category>
    {
        public CategoryRepository CategoryRepository
        {
            get
            {
                return base.Repository as CategoryRepository;
            }
        }

        public CategoryController() : base(new CategoryRepository())
        {
           
        }

        public Category GetCategoryByName(string name)
        {
            return CategoryRepository.GetCategoryByName(name);
        }
        public int RemoveCategoryByName(string name)
        {
            return CategoryRepository.RemoveCategoryByName(name);
        }
    }
}
