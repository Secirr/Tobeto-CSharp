using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Contrete;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class EducatorManager : IEducatorService
    {
        IEducatorDal _educationDal;

        public EducatorManager(IEducatorDal educationDal)
        {
            _educationDal = educationDal;
        }

        public IResult Add(Educator educator)
        {
            _educationDal.Add(educator);
            return new SuccessResult(Messages.CourseAdd);
        }

        public IResult Delete(Educator educator)
        {
            _educationDal.Delete(educator);
            return new SuccessResult(Messages.CourseDelete);
        }

        public IDataResult<List<Educator>> GetAll()
        {
            return new SuccesDataResult<List<Educator>>(Messages.CourseDelete, _educationDal.GetAll());
        }

        public List<Educator> GetAllByEducatorId(int id)
        {
            return _educationDal.GetAll(p => p.EducatorId == id);
        }

        public IDataResult<Educator> GetById(int id)
        {
            return new SuccesDataResult<Educator>(Messages.CourseDelete, _educationDal.Get(p => p.EducatorId == id));
        }

        public IResult Update(Educator educator)
        {
            _educationDal.Update(educator);
            return new SuccessResult(Messages.CourseDelete);
        }
    }
}
