using System.ComponentModel.DataAnnotations;

namespace CashierPOS.WebApi.DataValidation;

public class DataValidation<T>
{
    public static List<string> ValidateDynamicTypes(T obj)
    {
        var validationErrors = new List<string>();

        foreach (var property in typeof(T).GetProperties())
        {
            var value = property.GetValue(obj);

            // Check for the prop is [Required] 
            var isRequired = Attribute.IsDefined(property, typeof(RequiredAttribute));

            if (property.PropertyType == typeof(string))
            {
                ValidateString(property.Name, value?.ToString()!, isRequired, validationErrors);
            }
            else if (property.PropertyType == typeof(decimal?) || property.PropertyType == typeof(decimal))
            {
                ValidateNumber(property.Name, value!, isRequired, validationErrors);
            }
        }

        return validationErrors;
    }
    private static void ValidateString(string propertyName, string value, bool isRequired, List<string> errors)
    {
        if (isRequired && string.IsNullOrEmpty(value))
        {
            errors.Add($"Field {propertyName} is required.");
        }
    }
    private static void ValidateNumber(string propertyName, object value, bool isRequired, List<string> errors)
    {
        if (isRequired && value == null)
        {
            errors.Add($"Field {propertyName} is required and must be a valid number.");
        }
        else if (isRequired && value != null && value is decimal)
        {
            var numericValue = (decimal?)value;
            if (isRequired && numericValue == null)
            {
                errors.Add($"Field {propertyName} is required");
            }
            else if (numericValue != null && numericValue <= 0)
            {
                errors.Add($"Field {propertyName} must be greater than 0.");
            }
        }
    }

}
