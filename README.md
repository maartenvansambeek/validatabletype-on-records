# [ValidatableType on Records](https://github.com/dotnet/aspnetcore/issues/62315)
This repository allows reproducing the issue logged in https://github.com/dotnet/aspnetcore/issues/62315. For your convenience, it also contains the generated files in the [obj](obj/Debug/net10.0/generated/Microsoft.AspNetCore.Http.ValidationsGenerator/Microsoft.AspNetCore.Http.ValidationsGenerator.ValidationsGenerator)-folder.

## Steps to reproduce

Build the solution using the 10.0.100-preview.5.25277.114 version of dotnet:

```bash
dotnet build
```

Look at the generated file in the [obj](obj/Debug/net10.0/generated/Microsoft.AspNetCore.Http.ValidationsGenerator/Microsoft.AspNetCore.Http.ValidationsGenerator.ValidationsGenerator)-folder.

Line 64 contains metadata for the `ClassType`, but not the `RecordType`.
