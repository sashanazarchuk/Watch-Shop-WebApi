using BusinessLogic.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Validators
{
    public class WatchValidators : AbstractValidator<WatchDto>
    {
        public WatchValidators()
        {
            RuleFor(x => x.Model).NotNull().NotEmpty().Length(5,20);
            RuleFor(x => x.Brand).NotNull().NotEmpty().Length(5,20);
            RuleFor(x => x.Material).NotNull().NotEmpty().Length(5, 50);
            RuleFor(x => x.Price).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(x => x.Guarantee).NotNull().NotEmpty().Length(5, 20);
            RuleFor(x => x.img).NotNull().NotEmpty();
        }
    }
}
