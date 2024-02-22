﻿using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace InnoCheffing.API.Tools;

[AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = false)]
public sealed class StepNumberAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        bool result = true;

        if (value is null)
            return true;

        int stepNumber = Convert.ToInt32(value);

        if (stepNumber <= 0)
            result = false;

        return result;
    }

    public override string FormatErrorMessage(string name)
    {
        return String.Format(CultureInfo.CurrentCulture,
          //ErrorMessageString, 
          "The step number must be greater than zero.",
          name);
    }
}
