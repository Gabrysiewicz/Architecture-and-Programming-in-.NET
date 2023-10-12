# Laboratorium 7

# Zadanie 1 - ASP.NET + Individual
```
dotnet new mvc -au Individual --no-https -f net6.0
```

# Zadanie 2 - Modyfikacja domyślnej obsługi użytkownika
```
Modyfikacja Programu pod ApplicationUser

dotnet ef migrations add ApplicationUser
dotnet ef database update
```

# Zadanie 3 - Chinook
```
Import bazy danych oraz utworzenie modeli & relacji na bazie bazy...
dotnet ef dbcontext scaffold "Data Source=chinook.db" Microsoft.EntityFrameworkCore.Sqlite -c ChinookDbContext -o Models --context-dir Data

Wyswietlanie danych z bazy
```

# Zadanie 4 - Dodawanie klientów z bazy Chinook do Identity
```
Dodawanie oblugi logowania z haslem P@ssw0rd
```

# Zadanie 5 - Wyświetlanie listy zamówień zalogowanego klienta
```diff
+ Views/Home/MyOrders
```

# Zadanie 6 - Modyfikacja wyświetlania zamówień
```
Odruchowo wykonałem 50% zadanie 6 w zadaniu 5.
Zamiast konkatenować address w jeden wielki ciąg, zastosowałem colspan='5' w celu zespojenia danych
```

# Zadanie 7 - Modyfikacja ustawień regionalnych aplikacji
```
Date & Total są wyświetlane z wykorzystaniem lokalizacji (en-us)
```

# Zadanie 8 - Strona szczegółów zamówienia
```

```
