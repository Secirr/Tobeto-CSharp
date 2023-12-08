using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IEducatorService
    {
        IDataResult<List<Educator>> GetAll();
        IDataResult<Educator> GetById(int id);
        IResult Delete(Educator educator);
        IResult Update(Educator educator);
        IResult Add(Educator educator);
    }
}
