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
    public interface ICourseEducatorService
    {
        //Add,Update, Delete, Get,GetById
        IDataResult<List<CourseEducator>> GetAll();
        IDataResult<CourseEducator> GetById(int id);
        IResult Add(CourseEducator courseEducator);
        IResult Delete(CourseEducator courseEducator);
        IResult Update(CourseEducator courseEducator);

    }
}
