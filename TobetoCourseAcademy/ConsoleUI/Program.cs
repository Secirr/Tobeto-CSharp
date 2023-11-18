using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

CourseMenager courseManager = new CourseMenager(new EfCourseDal());
CourseEducatorMenager courseEducatorMenager = new CourseEducatorMenager(new EfCourseEducatorDal());

EducatorManager educatorManager = new EducatorManager(new EfEducatorDal());

var query = courseManager.GetCourseDetails();
if (query.Success)
{
    foreach (var item in query.Data)
    {
        Console.WriteLine(item.CategoryName + item.Name);
    }
}
else
{
    Console.WriteLine(query.Message);
}
//foreach (var item in courseManager.GetCourseDetails().Data)
//{
//    Console.WriteLine(item.Name);
//}



Console.ReadKey();































//foreach (var course in courseManager.GetAll())
//{
//    Console.WriteLine(course.Name);
//}

//foreach (var course in courseManager.GetAllByCategoryId(2))
//{
//    Console.WriteLine(course.Name);
//}

//foreach (var course in courseManager.GetAllByUnitPrice(1000, 2000))
//{
//    Console.WriteLine(course.Name);
//}




//foreach (var courseEducator in courseEducatorMenager.GetAllByCourseId("Programlamaya Giriş"))
//{
//    foreach (var item in educatorManager.GetAllByEducatorId(courseEducator.EducatorId))
//    {
//        Console.WriteLine(item.EducatorName);
//    }

//}