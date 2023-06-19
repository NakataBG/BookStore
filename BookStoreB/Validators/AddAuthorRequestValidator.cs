using BookStore.Models.Request;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace BookStoreB.Validators
{
    public class AddBookRequestValidator :
        AbstractValidator<AddAuthorRequest>
    {
        public AddBookRequestValidator()
        {
            RuleFor(x=> x.Name)
                 .NotEmpty()
                 .NotNull()
                 .MinimumLength(2)
                 .MaximumLength(10);
            RuleFor(x => x.Description)
                .NotEmpty();
        }
    }
}