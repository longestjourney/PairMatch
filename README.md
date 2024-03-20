# PairMatch
Program znajduje parę dwóch podobnych obrazków pod różnym kątem i obrotem.


# Założenia aplikacji
Aplikacja powinna wczytać zdjęcie z kartami z komputera w formatach PNG, JPG, BMP lub z podłączonej kamerki.
Następnie przetworzyć znajdujące się na kartach obrazy wg. charakterystycznych elementów wzorca.
Po wykonanych operacjach program powinien przedstawić wyniki powodzenia lub niepowodzenia.
Dodatkowo na danym obrazku jest tylko jedna para do znalezienia, jeśli jest ich więcej, znaleziony będzie ten wzorzec, który był pierwszy alfabetycznie w bazie danych, a baza
została wcześniej przygotowana lub zmodyfikowana przez użytkownika i tylko te elementy będą wyszukiwane.

Wykorzystuje algorytmy z bibioteki OpenCv tj. do detekcji: SIFT, KAZE, FAST, a także do dopasowywania Brute-Force Matcher, FLANN Matcher


# Podsumowanie i wnioski
Rozwiązań problemu wykrywania różnych obiektów, na przykład pary kart, jest bardzo wiele. Choć zasada ich działania wydaje się być podobna. Detekcja poszczególnych elementów: krawędzi, rogów, punktów kluczowych, w dużej mierze opiera się na rozmyciu obrazów, a następnie wyodrębnieniu tego co się wyróżnia. Wiele algorytmów Feature Matching opiera się na SIFT, ale próbuje usprawnić, przyspieszyć funkcjonalność, czasami kosztem na przykład dokładności detekcji obrotu, dlatego w przypadku bardziej sprecyzowanych programach można zastanowić się, który detektor i deskryptor najbardziej się przyda.
