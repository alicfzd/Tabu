using FluentValidation;
using Tabu.DTOs.Languages;

namespace Tabu.Validators.Validators
{
    public class LanguageUpdateDtoValidator : AbstractValidator<LanguageUpdateDto> 
    {
        public LanguageUpdateDtoValidator()
        {
            RuleFor(x => x.Name)
               .NotNull()
               .NotEmpty()
                   .WithMessage("Name boş ola bilməz")
               .MaximumLength(64)
                   .WithMessage("Name-in uzunluğu 64 dən artıq ola bilməz");
            RuleFor(x => x.Icon)
                .NotNull()
                .NotEmpty()
                    .WithMessage("Icon boş ola bilməz")
                .Matches("^http(s)?://([\\w-]+.)+[\\w-]+(/[\\w- ./?%&=])?$")
                    .WithMessage("Link olmalıdır")
                .MaximumLength(128)
                    .WithMessage("Icon uzunluğu 128 dən artıq ola bilməz");
        }
    }
   
}
