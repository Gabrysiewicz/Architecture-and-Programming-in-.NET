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

```

