using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Contrete;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseMenager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseMenager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public IResult Add(Course course)
        {
            _courseDal.Add(course);
            return new SuccessResult(Messages.CourseAdd);
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.CourseDelete);
        }


        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.CourseUpdate);
        }

        public IDataResult<List<Course>> GetAll()
        {
            return new SuccesDataResult<List<Course>>(Messages.CoursesList, _courseDal.GetAll());
        }
        public IDataResult<List<Course>> GetAllByCategoryId(int id)
        {
            return new SuccesDataResult<List<Course>> (Messages.CoursesListForCategoryId, _courseDal.GetAll(p=> p.CategoryID == id));
        }

        public IDataResult<List<Course>> GetAllByUnitPrice(double min, double max)
        {
            return new SuccesDataResult<List<Course>>(Messages.SelectCourses ,_courseDal.GetAll(p => p.Price >= min && p.Price <= max));
        }

        public IDataResult<Course> GetById(int id)
        {
            return new SuccesDataResult<Course>(Messages.GetCourse, _courseDal.Get(C=>C.Id == id));
        }

        public IDataResult<List<CourseDetailsDto>> GetCourseDetails()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<CourseDetailsDto>>("Barış Yıldırım");
            }
            return new SuccesDataResult<List<CourseDetailsDto>> (_courseDal.GetCourseDetails());
        }

    }
}
   
