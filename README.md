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
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 6.0

edit: Token configuration appsettings.json
feat(Token): Delivers JWT tokens
edit: Properties/launchSettings.json

Na tym etapie nie mam pewności czy działa tak jak miało działać
```

## Zadanie 4 - Migracja użytkowników
```
Add: Program.cs User z email kończącym się na @example.com zostaje dodany do grupy admin
Add: Obsługa rejestracji przez Api, feat(Register):in HomeController, Class RegistrationDto.cs
```

## Zadanie 5 - Uwierzytelnianie za pomocą tokena
```
Edit: Program.cs
Edit: FoxController.cs
```

## Zadanie 6 - Dostosowywanie reguł bezpieczeństwa
```
Edit: FoxController 
Edit: Program.cs (AddAuthorization)

Regular Token:
 - Love()
 - Hate()
Admin Token:
 - Add()
```
