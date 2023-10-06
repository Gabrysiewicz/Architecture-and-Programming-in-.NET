# Laboratorium 3

# Zadanie 1 - Create env
```
Skip
```

# Zadanie 2 - @DateTime
```
Spróbuj wykorzystać składnię Razor do osiągnięcia następującego efektu (tzw.
formatu daty długiej) dla aktualnej daty zamiast tekstu wprowadzającego.

Zmodyfikuj następnie plik Views/Home/Shared/_Layout.cshtml. Plik ten
zawiera główny układ treści aplikacji. W stopce znajduje się aktualny rok zapisywany
podczas generowania projektu – spróbuj zmodyfikować to w taki sposób, aby zawsze rok był
aktualny. Zwróć uwagę, że zmiana w pliku _Layout jest widoczna we wszystkich już
obecnych stronach aplikacji, np. na stronie polityki prywatności.
```

# Zadanie 3 - View Controller
```
W składni Razor możesz skorzystać z instrukcji warunkowych i innych instrukcji
sterujących.
Spróbuj opracować taki kod, który wyświetli liczbę losową z czerwonym tłem, jeśli
liczba będzie większa niż 0,5.
```

# Zadanie 4 - Scaffolding
```
W folderze Models dodaj nową klasę, która powinna być utworzona w przestrzeni
nazw z przyrostkiem .Models (np. Lab3.Models). Klasa ta będzie nazywać się Contact
i będzie przechowywać dane osobowe.

Oprócz właściwości Id, dodaj kolejne: Name, Surname, Email, City oraz
PhoneNumber, wszystkie typu string. Każdą z nich opatrz także atrybutem DisplayName,
który ją nazwie w sposób zrozumiały dla użytkownika – np. „Imię”, „Nazwisko” i tak dalej.
Automatyczny generator wykorzysta ten mechanizm, aby wygenerować tabelę i formularze
w odpowiedni sposób.
Usuń plik Views/Home/Index.cshtml, ponieważ będziemy generować go
z wykorzystaniem generatora.
```

# Zadanie 5 - Model
```
Dane do prezentowania w widoku w typowych aplikacjach pobierane są z innych
systemów informatycznych lub przede wszystkim z systemów baz danych. W tym
laboratorium zbudujemy fikcyjne źródło danych oparte o listę. W folderze Models utwórz
nową klasę, PhoneBookService i wypełnij ją następującą zawartością: ...
```

# Zadanie 6 - Access to Services
```
Aby zdefiniować, że kontroler HomeController będzie uzyskiwał dostęp do
automatycznie tworzonego obiektu klasy PhoneBookService należy zmodyfikować jego
konstruktor – dodaj, aby oczekiwany był obiekt klasy PhoneBookService i zapisz
przekazany obiekt do prywatnego pola kontrolera.
```

# Zadanie 7 - Views + Controller
```
Dodawanie formularza do dodawania nowych kontaktów
```

# Zadanie 8 - Delete
```
Dowawanie usuwania kontaktów
```

# Zadanie 9 - 404
```
Zabezpiecz usuwanie przed próbą wprowadzenia nie istniejącego id:
/Home/Delete/123
/Home/Delete/asd
```
