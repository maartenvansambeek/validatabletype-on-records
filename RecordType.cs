#pragma warning disable ASP0029
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.Validation;

/// <summary>
/// An example record type that will not be added to the generated validation property info.
/// </summary>
/// <param name="Name">The name that should be validated.</param>
[ValidatableType]
public record RecordType([property: Required][property: MinLength(2)] string Name);