using FluentValidation;
using System;

namespace RestApiDev.Library.Models
{
    public class PromotionModel
    {
        public string Name { get; set; }

        public bool IsComplete { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public class PromotionModelValidator : AbstractValidator<PromotionModel>
        {
            public PromotionModelValidator()
            {
                RuleFor(t => t.Name)
                    .MaximumLength(128)
                    .WithMessage("Name length can not be more than 128 char");

                RuleFor(t => t.StartDate)
                    .GreaterThan(DateTime.UtcNow);

                RuleFor(t => t.FinishDate)
                    .GreaterThan(DateTime.UtcNow)
                    .GreaterThan(t =>t.StartDate);
            }
        }
    }
}
