# Laboratorium 8

## Zadanie 1 - Dodawanie ASP.NET Identity do istniejącego projektu
```
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 6.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 6.0
dotnet add package Microsoft.AspNetCore.Identity.UI --version 6.0
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 6.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0
dotnet aspnet-codegenerator identity -sqlite
```

## Zadanie 2 - Dostosowywanie mechanizmu Identity
```
Skorzystałem z https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-configuration?view=aspnetcore-7.0

        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredLength = 8;
        options.Password.RequiredUniqueChars = 0;
```

## Zadanie 3 - Kontroler dostarczający tokeny dla użytkownika
```

```

## Zadanie 4 - Migracja użytkowników
```

```

## Zadanie 5 - Uwierzytelnianie za pomocą tokena
```

```

## Zadanie 6 - Dostosowywanie reguł bezpieczeństwa
```
nie posiadam archiwum wwwroot.zip

```
