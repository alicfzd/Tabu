using FluentValidation;
using Tabu.DTOs.Word;
using Tabu.Enums;

namespace Tabu.Validators.Word
{
    public class WordCreateDtoValidator : AbstractValidator<WordCreateDto>
    {
        public WordCreateDtoValidator()
        {
            RuleFor(x => x.Text)
                .NotEmpty()
                .NotNull()
                .MaximumLength(32);

            RuleFor(x => x.BannedWords)
                .NotNull()
                .Must(x => x.Count() == (int)GameLevel.Hard)
                .WithMessage((int)GameLevel.Hard + "unikal qadağan olunmuş söz yazılmalıdır");

            RuleForEach(x => x.BannedWords)
                .NotNull()
                .MaximumLength(32);
        }
    }
}
