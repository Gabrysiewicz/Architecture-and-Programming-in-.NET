# Laboratorium 4

# Zadanie 1 - Utworzenie projektu
```
Razor Pages
```

# Zadanie 2 - Wyświetlanie obrazów z 'servera'
```
Model index został zmodyfikowany aby obsługiwać ścieżki zależne od OS,
oraz zostało dodane wyświetlanie nazw plików w katalogu /wwwroot/images
```

# Zadanie 3 - Formularz z dodawaniem obrazów
```
Został dodany formularz do obsługi dodawanie plików.
Oraz metoda OnPost()
```

# Zadanie 4 - Dodanie przycisku do podstrony z formularzem
```
<a asp-page="Upload">Upload new file...</a>
```

# Zadanie 5 - Wyświetlanie obrazów
```
Zamiast nazw plików wyświetlane są obrazy jeden pod drugim, na środku strony.
```

# Zadanie 6 - Wyświetlanie pojedyńczego obrazu
```
Został dodany widok pojedyńczego obrazu oraz każdy obraz z galeri 
posiada hiperłącze do wyświetlenia tego konkretnego obrazu w pełnej rozdzielczości
```

# Zadanie 7 - Watermarks
```
Obraz watermark.png jest wykorzystywany w celu dodania watermark'a przesyłanym obrazom
```

# Important
```
Miałem problem z wysyłaniem plików na server z wykorzystaniem kodu z zadania, dlatego zmodyfikowałem zadanie.
W moim przypadku istnieją 3 katalogi:
- images (Zdjęcia bez watermark)
- gallery (Zdjęcia z watermark, te są wyświetlane na stronie)
- watermark (posiada tylko i wyłącznie watermark.png)
```
