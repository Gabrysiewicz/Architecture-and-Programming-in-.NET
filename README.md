# Laboratory 7

# Task 1 - ASP.NET + Individual
```
dotnet new mvc -au Individual --no-https -f net6.0
```

# Task 2 - Modifying the Default User Handling

Modification of Program for ApplicationUser
```
dotnet ef migrations add ApplicationUser
dotnet ef database update
```

# Task 3 - Chinook

Database Import and Creating Models & Relationships from the Database...
```
dotnet ef dbcontext scaffold "Data Source=chinook.db" Microsoft.EntityFrameworkCore.Sqlite -c ChinookDbContext -o Models --context-dir Data
```
Displaying Data from the Database

# Task 4 - Adding Chinook Database Customers to Identity

Adding Login Support with the Password P@ssw0rd


# Task 5 - Displaying the Order List of the Logged-In Customer


# Task 6 - Modifying the Display of Orders

# Task 7 - Modifying the Application’s Culture Settings

Date & Total are displayed using the en-US locale

# Task 8 - Order Details Page

Further modification of models, correcting data types
Creating a view for OrderDetails
Handling many-to-many relationships


# Task 9 - Order Viewing Restrictions

OrderDetails additionally checks whether the given order belongs to the logged-in user.
If it does not, or the order details do not exist, an access denied message is returned:
```
 Forbid()
```

# Task 10 - Changing Paths in the Routing Mechanism

Modification of Program.cs


# Task 11 - Visibility Only for Logged-In Users

A method allowing visibility restriction for non-logged-in users
was used in Index.cshtml in the same way as in _LoginPartial.cshtml.
Only a logged-in user can see the link to "My Orders".
