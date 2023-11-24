using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Contrete;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Messages.CourseAdd);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.CourseDelete);
        }
        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.CourseUpdate);
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccesDataResult<List<Category>>(Messages.CoursesList, _categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int id)
        {
            return new SuccesDataResult<Category>(_categoryDal.Get(p => p.Id == id));
        }


    }
}