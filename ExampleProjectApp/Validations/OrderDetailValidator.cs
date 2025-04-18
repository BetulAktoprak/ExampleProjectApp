using System.Text.RegularExpressions;
using ExampleProjectApp.Entities;
using FluentValidation;

namespace ExampleProjectApp.Validations
{
    public class OrderDetailValidator : AbstractValidator<OrderDetail>
    {
        public OrderDetailValidator()
        {
            RuleFor(x => x.Quantity)
                .GreaterThan(0).WithMessage("Miktar 0'dan büyük olmalıdır.");

        }
    }
}
