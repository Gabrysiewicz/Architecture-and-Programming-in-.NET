# Laboratory 9

## Task 1 - Adding ASP.NET Identity to an Existing Project
```
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 6.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 6.0
dotnet add package Microsoft.AspNetCore.Identity.UI --version 6.0
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 6.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0
dotnet aspnet-codegenerator identity -sqlite
```

## Task 2 - Customizing the Identity Mechanism
```
I used: https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-configuration?view=aspnetcore-7.0

        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredLength = 8;
        options.Password.RequiredUniqueChars = 0;
```

## Task 3 - Controller Providing Tokens for the User
```
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 6.0

edit: Token configuration appsettings.json
feat(Token): Delivers JWT tokens
edit: Properties/launchSettings.json
```

## Task 4 - User Migration
```
Add: Program.cs User with email that end with @example.com has been added to admin group
Add: API sign up option, feat(Register):in HomeController, Class RegistrationDto.cs
```

## Task 5 - Token-Based Authentication
```
Edit: Program.cs
Edit: FoxController.cs
```

## Task 6 - Customizing Security Rules
```
Edit: FoxController 
Edit: Program.cs (AddAuthorization)

Regular Token:
 - Love()
 - Hate()
Admin Token:
 - Add()
```
