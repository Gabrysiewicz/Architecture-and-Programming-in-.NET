# Laboratory 5

# Task 1 - Create a project
```
.NET ASP MVC
NuGet: Sqlite 6.0.22
```

# Task 2 - Movie class + MoviesDbContext
A class representing movies has been created, along with a class responsible for managing database interactions and relationships.


# Task 3 - Database connection

The `secrets.json` file was modified to store sensitive configuration data, and necessary dependencies were added in `Program.cs` to ensure proper application setup and database connectivity.


# Task 4 - Generate a controller

A controller for the `Movie` class was generated automatically, and database migrations were created to reflect the changes in the data model. This ensures proper CRUD operations for movie records in the database.

# Task 5 - # Data Input Modification

After creating the template and modifying the `Description` attribute in the model, the input started working correctly.  
Alternatively, this can also be implemented without using a template.  
Reference: [Textarea with Html.EditorFor](https://techfunda.com/howto/408/textarea-with-html-editorfor)

# Task 6 - # Data Display Modification

The display of the `Rating` field has been replaced with stars.  
A custom template has been added specifically for the rating display.


# Task 7  - # Trailer Display as Link

The trailer is now displayed as a clickable link using the `<a href="">` element, added in the necessary locations.


# Task 8 - # Trailer Display

The trailer is displayed in the Details view using the URL format:

https://www.youtube.com/embed/{youtubeID}

where `{youtubeID}` is replaced with the movie's YouTube video ID.



