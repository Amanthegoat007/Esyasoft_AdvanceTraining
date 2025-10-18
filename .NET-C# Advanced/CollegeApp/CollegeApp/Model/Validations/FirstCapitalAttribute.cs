using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model.Validations
{
    public class FirstCapitalAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var name = value as string;
            if (name == null) return new ValidationResult("Enter some value as name!!");
            if (name[0] >= 'A' && name[0] <= 'Z') return ValidationResult.Success;
            else return new ValidationResult("Please Enter First Letter as Captital");
        }
    }
}
