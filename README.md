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

```
