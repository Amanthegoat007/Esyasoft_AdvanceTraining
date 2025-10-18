using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model.Validations
{
    public class SpaceCheckAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var input = value as string;

            if (string.IsNullOrWhiteSpace(input))
            {
                return new ValidationResult("Please enter a valid value.");
            }

            if (input.Contains(" "))
            {
                return new ValidationResult("Spaces are not allowed.");
            }

            return ValidationResult.Success;
        }
    }
}
