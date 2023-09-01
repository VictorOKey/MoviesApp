using System;
using System.ComponentModel.DataAnnotations;
using MoviesApp.Models;


public class MinStringLengthAttribute: ValidationAttribute 
{
    public int MinLength
    {
        get;
    }

    public MinStringLengthAttribute(int minLength)
    {
        MinLength = minLength;
    } 
    public string GetErrorMessage() => $"String must contain {MinLength} letters minimum";

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var str = (string) value; if (str.Length < MinLength) { return new ValidationResult(GetErrorMessage()); } 
        return ValidationResult.Success;
    }
    
}