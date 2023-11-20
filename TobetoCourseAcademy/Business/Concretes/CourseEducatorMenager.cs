using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Contrete;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseEducatorMenager : ICourseEducatorService
    {
        ICourseEducatorDal _courseEducationDal;

        public CourseEducatorMenager(ICourseEducatorDal courseEducationDal)
        {
            _courseEducationDal = courseEducationDal;
        }


        //Add,Update, Delete, Get,GetById

        public IResult Add(CourseEducator courseEducator)
        {
            _courseEducationDal.Add(courseEducator);
            return new SuccessResult(Messages.CourseAdd);
        }

        public IResult Delete(CourseEducator courseEducator)
        {
            _courseEducationDal.Delete(courseEducator);
            return new SuccessResult(Messages.CourseDelete);
        }

        public IDataResult<List<CourseEducator>> GetAll()
        {
            return new SuccesDataResult<List<CourseEducator>>(Messages.CoursesList, _courseEducationDal.GetAll());
        }

        public IDataResult<CourseEducator> GetById(int id)
        {
            return new SuccesDataResult<CourseEducator>(_courseEducationDal.Get(p => p.Id == id));
        }

        public IResult Update(CourseEducator courseEducator)
        {
            _courseEducationDal.Update(courseEducator);
            return new SuccessResult(Messages.CourseDelete);
        }
    }
}
