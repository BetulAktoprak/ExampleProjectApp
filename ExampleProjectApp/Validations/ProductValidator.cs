using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ExampleProjectApp.Entities;
using FluentValidation;

namespace ExampleProjectApp.Validations
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName)
            .NotEmpty().WithMessage("Ürün adı boş olamaz.")
            .MaximumLength(100).WithMessage("Ürün adı en fazla 100 karakter olabilir.");

            RuleFor(p => p.UnitPrice)
                .GreaterThan(0).WithMessage("Birim fiyatı 0'dan büyük olmalıdır.")
                .Must(price => IsDecimal(price.ToString())).WithMessage("Birim fiyatı sayısal olmalıdır.");

            RuleFor(p => p.Stock)
                .GreaterThanOrEqualTo(0).WithMessage("Stok miktarı negatif olamaz.")
                .Must(stock => IsInteger(stock.ToString())).WithMessage("Stok değeri sayısal olmalıdır.");

            RuleFor(p => p.Description)
                .MaximumLength(500).WithMessage("Açıklama en fazla 500 karakter olabilir.");

            RuleFor(p => p.Kilo)
                .GreaterThanOrEqualTo(0).WithMessage("Kilo değeri negatif olamaz.")
                .Must(kilo => IsDecimal(kilo.ToString())).WithMessage("Kilo değeri sayısal olmalıdır.");

            RuleFor(p => p.Metre)
                .GreaterThanOrEqualTo(0).WithMessage("Metre değeri negatif olamaz.")
                .Must(metre => IsDecimal(metre.ToString())).WithMessage("Metre değeri sayısal olmalıdır.");
        }

        private bool IsDecimal(string input)
        {
            return Regex.IsMatch(input, @"^\d+(\.\d{1,2})?$");
        }

        private bool IsInteger(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }
    }
}
