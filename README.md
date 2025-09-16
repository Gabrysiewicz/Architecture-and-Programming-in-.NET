# Laboratory 6

# Task 1 - Adding Constraints to Model Fields

Constraints on fields are added using attributes such as
[Required], [Range(min, max)] or [MaxLength(number)] in a similar way
that the [UIHint] attribute was used in Laboratory 5.
Modify the file Movie.cs in the Movies/ folder and add the following constraints:
• The Title property must be required and have a maximum of 50 characters,
• The Description property must be required,
• The Rating property must have a range from 1 to 5.


# Task 2 - Custom Error Messages

To use a custom error message, you can set the
ErrorMessage property of a validation attribute, for example:
	[UIHint("Stars")]
	[Range(1, 5, ErrorMessage = "The movie rating must be a number between 1 and 5")]
	public int Rating { get; set; }
Try modifying the application so that custom error messages are displayed
for all fields.


# Task 3 - Client-Side Validation


# Task 4 - Adding Another Table and a Relationship Between Tables in the Database

You should start by adding a new data model – add a new public class in
the Models/ folder named Genre, which will have two properties – Id and Name.
```
public class Genre
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}
```
In the data context class, MovieDbContext, add a reference to the database
table for movie genres by adding the property:
```
public DbSet<Genre> Genres { get; set; }
```
Next, in the Movie class, add a reference to the movie genre by adding the property:
```
public Genre Genre { get; set; }
```
As you can guess, you need to perform a database migration because the data
model has changed. Open the terminal and run the command:
```
dotnet ef migrations add Genre
```

# Task 5 - Modifying the Genre Migration

Migrations are generated as classes in the Migrations/ folder. Find the migration
file named Genre; its filename will look like data_Genre.cs. In this file,
in the Up() method, modify the default value of the added GenreId column to 1.
Then, after the command that creates the Genres table
(migrationBuilder.CreateTable(name: "Genres", …)), add manual data insertion:
```
migrationBuilder.InsertData(
	"Genres",
	new string[] { "Id", "Name" },
	new object[] { "1", "unknown" }
);
```
Now, you can update the database to the new schema by running the command:
```
dotnet ef database update
```
As a result, all movies that did not have an assigned genre will now have the genre "unknown".
You can run the application, but you may notice that it does not work correctly,
because the form for adding a new movie and editing an existing one does not work,
and the movie genre is not displayed anywhere.

# Task 6 - Displaying the Movie Genre in the List

Modify the view Views/Home/Index.cshtml by adding one more column
in the table header in the second-to-last position:
```
<th>
  @Html.DisplayNameFor(model => model.Genre)
</th>
  Oraz wypełniając ją zawartością wewnątrz pętli foreach:
<td>
  @Html.DisplayFor(modelItem => item.Genre.Name)
</td>
```
However, it is necessary to pass to the view a data model that includes the populated Genre value,
since it is not fetched from the database by default (lazy loading).
In the HomeController, in the Index method, modify the database query
to also include movie genres:
```
_context.Movies.Include(x => x.Genre).ToListAsync()
```


# Task 7 - Handling the Addition of a New Movie and Its Genre
You may notice that the Movie data model differs from what we would like to achieve –
it contains a property of type Genre, whereas we want the user to be able to manually
enter a value into a text field, which will then be mapped to an existing database record
or a newly added record. Therefore, it will be necessary to prepare a different model
representing the database entity and an object received from the user.

This approach is called intermediate models, DTOs (Data Transfer Objects),
or sometimes referred to as a ViewModel, following the MVVM architecture pattern
where such intermediate classes exist between the model and the view.

Prepare a new class, MovieDto, which will be almost identical to the Movie class

# Task 8 - Using the <datalist> Element to Provide Suggestions

We want the user to be able to select an existing item from the list of genres,
which will be suggested as they type a fragment of text into an <input> field.
Here, the HTML5 <datalist> element can be used.

However, it is necessary to pass all existing movie genres from the database
to generate this list.

Add one more property to the MovieDto class:
```
public List<string>? AllGenres { get; set; }
```

Next, modify the view Views/Home/Create.cshtml to generate a <datalist> element
inside the <div> containing the <input> for Genre using the following approach:
```
<datalist id="genres">
@foreach (var item in Model.AllGenres)
{
@Html.Raw($"<option value=\"{item}\">")
}
</datalist>
```
Finally, add the list attribute to the <input> element for Genre,
pointing to the corresponding <datalist> element:
```
<input asp-for="Genre" class="form-control" list="genres" />
```
The final step will be populating the AllGenres list when generating the form
for adding a new movie. In the HomeController, in the Create() method
(the variant not marked with the [HttpPost] attribute), you can implement it as follows:
```
public IActionResult Create()
{
var m = new MovieDto { AllGenres =
_context.Genres.Select(x => x.Name).ToList() };
return View(m);
}
```

