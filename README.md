# Laboratorium 2

# Zadanie 1 - Class
```
Wygeneruj nowy projekt korzystając z szablonu aplikacji konsolowej. Następnie,
dodaj do swojego projektu nowy plik Fruit.cs, który będzie zawierał klasę Fruit.
Klasa Fruit powinna zawierać trzy właściwości: Name, typu string, IsSweet,
typu bool oraz Price, typu double.
W klasie Fruit utwórz publiczną statyczną metodę fabrykującą o nazwie Create(),
która będzie generować i zwracać nowy obiekt typu Fruit o losowej nazwie spośród zbioru
nazw, metoda powinna również ustawiać IsSweet oraz Price na wartości losowe.
```

# Zadanie 2 - Override
```
Z tego też powodu niezbędne będzie przeciążenie operacji ToString()
wykonywanej na klasie Fruit. Dodaj do klasy Fruit publiczną metodę zwracającą typ
string o nazwie ToString() – musisz jednak użyć także słowa kluczowego override,
które wymusi polimorfizm 
```

# Zadanie 3 - Linq
```
Zmodyfikuj wyświetlanie elementów w taki sposób, aby wyświetlane były tylko
elementy w których właściwość IsSweet jest ustawiona na True, posortowane względem
ceny, malejąco.
```

# Zadanie 4 - Async
```
Rzadko zdarza się, aby cały program działał całkowicie synchronicznie – mechanizmy
zrównoleglania i asynchroniczności są bardzo popularne w wielu językach programowania.
Dodaj do swojego projektu nową klasę, która będzie nazywać się UsdCourse. Zawierać ona
będzie metodę, która komunikuje się z Internetem i pobiera aktualny kurs dolara. Zapytanie
do zewnętrznego serwisu internetowego jest wykonywane w sposób asynchroniczny, stąd
metoda GetUsdCourseAsync() ma wykorzystane słowo kluczowe async, z zwraca
Task<float>, czyli nie wartość typu float, ale „obietnicę” zwrócenia float
w przyszłości.
```

# Zadanie 5 - TODO
```

```
