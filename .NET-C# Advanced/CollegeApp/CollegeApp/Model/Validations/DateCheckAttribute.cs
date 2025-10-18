using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model.Validations
{
    public class DateCheckAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var date = value as DateTime?;

            if (date == null)
            {
                return new ValidationResult("Please enter a date.");
            }

            // Compare only date part (ignore time)
            if (date.Value.Date <= DateTime.Now.Date)
            {
                return new ValidationResult("Date must be greater than today's date.");
            }

            return ValidationResult.Success;
        }
    }
}