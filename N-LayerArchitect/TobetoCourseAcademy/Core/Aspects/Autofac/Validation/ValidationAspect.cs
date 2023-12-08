using System;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;

namespace Core.Aspects.Autofac.Validation
{

        public class ValidationAspect : MethodInterception
        {
            private Type _validatorType;
            public ValidationAspect(Type validatorType) //Atribute lar type ile çağrılır(courseValidator)
            {
                if (!typeof(IValidator).IsAssignableFrom(validatorType)) //Abstract / IValidator(miras alma)
                {
                    throw new System.Exception("This isn't validation class.");
                }

                _validatorType = validatorType;
            }
            protected override void OnBefore(IInvocation invocation)
            {
                var validator = (IValidator)Activator.CreateInstance(_validatorType);
                var entityType = _validatorType.BaseType.GetGenericArguments()[0]; //validatorun type ıne eşit olan parametrelere eşle
                var entities = invocation.Arguments.Where(t => t.GetType() == entityType); //validatorun type ıne eşit olan parametrelere getir
            foreach (var entity in entities)
                {
                    ValidationTool.Validate(validator, entity);
                }
            }
        }
    }

