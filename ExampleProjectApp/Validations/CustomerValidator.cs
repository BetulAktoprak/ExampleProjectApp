using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleProjectApp.Entities;
using FluentValidation;

namespace ExampleProjectApp.Validations
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FullName)
           .NotEmpty().WithMessage("Ad Soyad boş olamaz.")
           .MinimumLength(2).WithMessage("Ad Soyad en az 2 karakter olmalıdır.")
           .Matches(@"^[a-zA-ZçÇğĞıİöÖşŞüÜ\s]+$").WithMessage("Ad Soyad sadece harf ve boşluk içermelidir.");

            RuleFor(x => x.TCNo)
                .NotEmpty().WithMessage("T.C. Kimlik Numarası boş olamaz.")
                .Length(11).WithMessage("T.C. Kimlik Numarası 11 haneli olmalıdır.")
                .Matches(@"^[1-9][0-9]{10}$").WithMessage("Geçerli bir T.C. Kimlik Numarası giriniz.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Telefon numarası boş olamaz.")
                .Matches(@"^5\d{9}$").WithMessage("Telefon numarası 5 ile başlamalı (örn: 5xx1234567).");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("E-posta adresi boş olamaz.")
                .Matches(@"^[^@\s]+@[^@\s]+\.[^@\s]+$").WithMessage("Geçerli bir e-posta adresi giriniz. (örn: ornek@gmail.com)");


            RuleFor(x => x.VergiNo)
                .NotEmpty().WithMessage("Vergi Numarası boş olamaz.")
                .Length(10).WithMessage("Vergi Numarası 10 haneli olmalıdır.")
                .Matches(@"^\d{10}$").WithMessage("Vergi Numarası sadece rakamlardan oluşmalıdır.");

            RuleFor(x => x.VergiDairesi)
                .NotEmpty().WithMessage("Vergi Dairesi boş olamaz.")
                .MinimumLength(2).WithMessage("Vergi Dairesi en az 2 karakter olmalıdır.");
        }

    }
}
