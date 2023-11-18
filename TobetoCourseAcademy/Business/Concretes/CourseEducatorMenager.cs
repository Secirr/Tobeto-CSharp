using Business.Abstracts;
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
        ICourseEducatorDal _icourseEducationDal;

        public CourseEducatorMenager(ICourseEducatorDal icourseEducationDal)
        {
            _icourseEducationDal = icourseEducationDal;
        }

       
        public List<CourseEducator> GetAllByCourseId(string name)
        {
            return _icourseEducationDal.GetAll(p=> p.Course.Name == name);
        }
    }
}
