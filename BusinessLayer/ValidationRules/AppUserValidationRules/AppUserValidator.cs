using DtoLayer.Dtos.AppUserDtos;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserValidator: AbstractValidator<AppUserRegisterDto>
    {
        public AppUserValidator() {

            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş bırakılamaz!");
            RuleFor(x => x.Name).MaximumLength(10).WithMessage("Ad alanına en fazla 10 karakter yazılabilir");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Ad en az 2 karakterden oluşmalıdır.");
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Soyadı alanı boş bırakılamaz!");
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage("Soyadı alanına en fazla 20 karakter yazılabilir");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Soyadı en az 2 karakterden oluşmalıdır.");

        }
    }
}
