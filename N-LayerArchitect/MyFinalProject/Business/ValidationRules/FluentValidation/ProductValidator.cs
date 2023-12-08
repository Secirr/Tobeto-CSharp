using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class ProductValidator : AbstractValidator<Product>
	{
		public ProductValidator()
		{
			RuleFor(p => p.ProductName).NotEmpty(); //Boş olamaz
            RuleFor(p=> p.ProductName).MinimumLength(2); //En az 2harfli olmalı
			RuleFor(p => p.UnitPrice).NotEmpty(); //Boş olamaz
			RuleFor(p => p.UnitPrice).GreaterThan(0); //Unitprice 0 dan büyük olmalı
			RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p=>p.CategoryId==1); //id 1 iken ürün fiyatı minimm 10 olmalı
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı."); //Boş olamaz
        }

        private bool StartWithA(string arg)
        {
			return arg.StartsWith("A");
        }
    }
}

