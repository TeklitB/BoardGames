﻿using System.ComponentModel.DataAnnotations;

namespace BoardGames.RestApi.Attributes
{
  public class SortOrderValidatorAttribute : ValidationAttribute
  {
    public string[] AllowedValues { get; set; } = ["ASC", "DESC"];
    public SortOrderValidatorAttribute()
    : base("Value must be one of the following: {0}.") { }
    protected override ValidationResult IsValid(
    object value,
    ValidationContext validationContext)
    {
      var strValue = value as string;
      if (!string.IsNullOrEmpty(strValue)
      && AllowedValues.Contains(strValue))
      {
        return ValidationResult.Success;
      }

      return new ValidationResult(
      FormatErrorMessage(string.Join(",", AllowedValues))
      );
    }
  }
}
