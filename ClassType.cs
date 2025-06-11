
#pragma warning disable ASP0029 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.Validation;

/// <summary>
/// An example record type that will not be added to the generated validation property info.
/// </summary>
/// <param name="name">The name that should be validated.</param>
[ValidatableType]
public class ClassType(string name)
{
    /// <summary>
    /// Gets the name that should be validated.
    /// </summary>
    [Required]
    [MinLength(2)]
    public string Name { get; init; } = name;
}