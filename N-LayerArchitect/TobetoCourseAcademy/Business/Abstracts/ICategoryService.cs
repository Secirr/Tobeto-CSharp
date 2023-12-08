using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int id);
        IResult Delete(Category category);
        IResult Update(Category category);
        IResult Add(Category category);

    }
}
