using System;
using Entities.Concretes;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class CourseValidator : AbstractValidator<Course>
	{
        public CourseValidator()
        {
            RuleFor(c => c.Name).NotEmpty(); //Boş olamaz
            RuleFor(c => c.Name).MinimumLength(2); //En az 2harfli olmalı
            RuleFor(c => c.Price).NotEmpty(); //Boş olamaz
            RuleFor(c => c.Price).GreaterThan(0); //price 0 dan büyük olmalı
            RuleFor(c => c.Price).GreaterThanOrEqualTo(10).When(c => c.CategoryID == 1); //id 1 iken kurs fiyatı minimm 10 olmalı
            RuleFor(c => c.Name).Must(StartWithA).WithMessage("Courses should start with the letter A."); //Boş olamaz
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}

