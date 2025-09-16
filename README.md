# Laboratory 3

# Task 1 - Create env

# Task 2 - @DateTime
Try using Razor syntax to achieve the following effect (so-called long date format) for the current date instead of the introductory text.

Then, modify the file `Views/Home/Shared/_Layout.cshtml`. This file contains the main layout of the application content.  

In the footer, the current year is hardcoded from when the project was generated – try modifying it so that the year is always current. Note that changes in the `_Layout` file will be reflected on all existing pages of the application, e.g., on the privacy policy page.


# Task 3 - View Controller
In Razor syntax, you can use conditional statements and other control structures.  

Try to write code that displays a random number with a red background if the number is greater than 0.5.


# Task 4 - Scaffolding
In the `Models` folder, add a new class that should be created in a namespace with the `.Models` suffix (e.g., `Lab3.Models`). This class will be named `Contact` and will store personal data.

In addition to the `Id` property, add the following properties: `Name`, `Surname`, `Email`, `City`, and `PhoneNumber`, all of type `string`.  

Also, annotate each property with a `DisplayName` attribute, which will give it a user-friendly name – e.g., “Name”, “Surname”, and so on. The scaffolding generator will use this mechanism to generate tables and forms appropriately.  

Delete the file `Views/Home/Index.cshtml` because we will generate it using the scaffolding generator.


# Task 5 - Model
Data for display in views in typical applications is usually retrieved from other IT systems or, most commonly, from database systems. In this lab, we will create a fictional data source based on a list.  

In the `Models` folder, create a new class called `PhoneBookService` and populate it with the following content: ...look into pdf...

# Task 6 - Access to Services
To define that the `HomeController` will have access to the automatically created instance of the `PhoneBookService` class, you need to modify its constructor – add a parameter expecting an object of type `PhoneBookService` and store the passed object in a private field of the controller.


# Task 7 - Views + Controller
Adding a form for creating new contacts


# Task 8 - Delete
Adding functionality for deleting contacts


# Task 9 - 404
Secure the deletion functionality to prevent attempts to delete non-existent or invalid IDs, e.g.:

- /Home/Delete/123  → valid numeric ID but must exist
- /Home/Delete/asd  → invalid ID (non-numeric)

Implement proper validation in the controller to handle such cases gracefully, e.g., return `NotFound()` or redirect with an error message if the ID is invalid or does not exist.


# Final Commit 
## Task 3

The welcome text with random numbers and color formatting of those numbers has already been added in the content from Task 9. 

