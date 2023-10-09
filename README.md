# Laboratorium 6

# Zadanie 1 - Dodawanie ograniczeń do pól modelu
```
Ograniczenia w stosunku do pól dodawane są za pomocą atrybutów, takich jak
[Required], [Range(min, max)] lub [MaxLength(liczba)] w podobny sposób, jak
w Laboratorium 5 wykorzystywany był atrybut [UIHint].
Zmodyfikuj plik Movie.cs z folderu Movies/ i dodaj do niego ograniczenia:
• właściwość Title ma być wymagana i mieć co najwyżej 50 znaków,
• właściwość Description ma być wymagana,
• właściwość Rating ma mieć zakres od 1 do 5.
```

# Zadanie 2 - Własne opisy błędów
```
Aby zastosować własny komunikat błędu, możesz ustawić właściwość
ErrorMessage atrybutu walidacji, na przykład tak:
	[UIHint("Stars")]
	[Range(1, 5, ErrorMessage = "Ocena filmu musi być liczbą pomiędzy 1 a 5")]
	public int Rating { get; set; }
Spróbuj zmodyfikować aplikację tak, aby wyświetlane były własne komunikaty
błędów dla wszystkich pól.
```

# Zadanie 3 - Walidacja po stronie klienta
```
Chyba działa
data-val-* były zarówno z jQuery jak i bez
```

# Zadanie 4 - Dodawanie kolejnej tabeli oraz relacji pomiędzy tabelami w bazie danych
```
Należy zacząć od dodania nowego modelu danych – dodaj nową publiczną klasę w
folderze Models/ o nazwie Genre, która będzie posiadać dwie właściwości – Id oraz Name.

public class Genre
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}

W klasie kontekstu danych, MovieDbContext, dodaj odwołanie do tabel
bazodanowej gatunków filmowych dodając właściwość:

public DbSet<Genre> Genres { get; set; }

Następnie, w klasie Movie dodaj odwołanie do gatunku filmowego, dodając
właściwość:

public Genre Genre { get; set; }

Jak się domyślasz, należy przeprowadzić migrację bazy danych, ponieważ model
danych uległ zmianie. Otwórz terminal i wydaj komendę:

dotnet ef migrations add Genre

```

# Zadanie 5 - Modyfikacja migracji Genre
```
Migracje generowane są jako klasy w folderze Migrations/. Znajdź plik migracji
o nazwie „Genre”, jego nazwa pliku będzie miała postać „data_Genre.cs”. W pliku tym,
w metodzie Up() zmodyfikuj domyślną wartość dodawanej kolumny GenreId na 1.
Następnie, po poleceniu tworzenia tabeli Genres (postaci
migrationBuilder.CreateTable(name: "Genres", …) dodaj ręczne dodawanie danych:

migrationBuilder.InsertData(
	"Genres",
	new string[] { "Id", "Name" },
	new object[] { "1", "unknown" }
);

Teraz, możesz już wykonać aktualizację bazy danych do nowego schematu, wydając
komendę:

dotnet ef database update

A w jej wyniku wszystkie filmy, które nie miały przypisanego gatunku uzyskają
gatunek „unknown”.
Możesz uruchomić aplikację, ale możesz zauważyć, że nie działa ona poprawnie,
ponieważ formularz dodawania nowego filmu i edycji starego nie działają, a gatunek filmowy
nie jest nigdzie wyświetlany.

```

# Zadanie 6 - Wyświetlanie gatunku filmowego na liście
```
Zmodyfikuj widok Views/Home/Index.cshtml dodając jeszcze jedną kolumnę
w nagłówku tabeli na przedostatnim miejscu:

<th>
  @Html.DisplayNameFor(model => model.Genre)
</th>
  Oraz wypełniając ją zawartością wewnątrz pętli foreach:
<td>
  @Html.DisplayFor(modelItem => item.Genre.Name)
</td>

Niezbędne jest jednak przekazanie do widoku modelu danych, który będzie zawierał
wypełnioną wartość Genre, jako, że domyślnie nie jest pobierana z bazy danych (lazy
loading).
W kontrolerze HomeController, w metodzie Index, zmodyfikuj wybieranie
wartości z bazy danych, aby uwzględniało także gatunki filmowe:

_context.Movies.Include(x => x.Genre).ToListAsync()

```

# Zadanie 7 - Obsługa dodawania nowego filmu i jego gatunku filmowego
```
Możesz zauważyć, że model danych Movie różni się od tego, co chcielibyśmy
uzyskać – zawiera właściwość typu Genre, podczas gdy chcemy, aby użytkownik miał
możliwość ręcznego wpisania wartości do pola tekstowego, które zostanie zmapowane na
istniejący rekord w bazie lub na nowododany rekord. Niezbędne zatem będzie przygotowanie
innego modelu reprezentującego encję bazodanową oraz obiekt odbierany od użytkownika.
Takie podejście nazywa się modelami pośrednimi, DTO (Data Transfer Objects) lub czasami
używane jest określenie ViewModel na wzór architektury MVVM w której również istnieją
takie klasy pośrednie pomiędzy modelem i widokiem.
Przygotuj nową klasę, MovieDto, która będzie prawie identyczna jak klasa Movie
```

# Zadanie 8 - Wykorzystanie elementu <datalist> do tworzenia podpowiedzi
```
TODO
```
