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

# Zadanie 5 - ToStringAsync
```
Dodaj do swojej klasy Fruit właściwość UsdPrice – będzie ona obliczała cenę
w dolarach na podstawie ceny bazowej.
```

# Zadanie 6 - MyFormatter
```
Kultura („locale”) to zestaw informacji, które opisują w jaki sposób należy wyświetlać
format daty, godziny, czy też liczb i walut w zależności od regionu świata i używanego
języka. Jak prawdopodobnie wiesz, w Polsce waluta wyświetlana jest w formacie „0,99 zł”,
natomiast w USA – „$0.99”. Należy dodać do naszego programu mechanizm, aby cena
bazowa (Price) była wyświetlana poprzez zwykłe formatowanie walut, a cena w dolarach
w sposób odpowiedni dla USA.
Dodaj do swojego programu nową klasę, MyFormatter.
Klasa ta będzie zawierać jedną metodę statyczną, FormatUsdPrice, która będzie
przyjmować double i zwracać string.
```
