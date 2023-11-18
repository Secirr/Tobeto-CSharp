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
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAll();
        IDataResult<List<Course>> GetAllByCategoryId(int id);
        IDataResult<List<Course>> GetAllByUnitPrice(double min, double max);
        IDataResult<List<CourseDetailsDto>> GetCourseDetails();
        IDataResult<Course> GetById(int id);
        IResult Add(Course course);
        IResult Delete(Course course);
        IResult Update(Course course);
    }
}
