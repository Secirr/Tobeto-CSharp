using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddSingleton<ICourseService, CourseMenager>();
            builder.Services.AddSingleton<ICourseDal, EfCourseDal>();

            builder.Services.AddSingleton<ICategoryService, CategoryManager>();
            builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();

            builder.Services.AddSingleton<IEducatorService, EducatorManager>();
            builder.Services.AddSingleton<IEducatorDal, EfEducatorDal>();

            builder.Services.AddSingleton<ICourseEducatorService, CourseEducatorMenager>();
            builder.Services.AddSingleton<ICourseEducatorDal, EfCourseEducatorDal>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}