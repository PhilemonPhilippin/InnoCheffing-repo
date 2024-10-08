using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace InnoCheffing.API.Tools;

[AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = false)]
public sealed class StepNumberAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        bool result = true;

        // Step number can be null, it's valid.
        if (value is null)
            return true;

        // But Step number must be greater than 0.
        if (value is int stepNumber)
        {
            if (stepNumber <= 0)
                return false;
        }

        return result;
    }

    public override string FormatErrorMessage(string name)
    {
        return string.Format(CultureInfo.CurrentCulture,
          //ErrorMessageString, 
          "The step number must be greater than zero.",
          name);
    }
}
