Opis funkcjonalności projektu strony blogowej:
Projekt strony blogowej ma za zadanie użytkownikom wygodne korzystanie z platformy.
Poniżej przedstawiono główne funkcje strony:

Rejestracja i Logowanie:
-Użytkownicy mają możliwość tworzenia nowych kont poprzez proces rejestracji.
Zarejestrowani użytkownicy mają dostęp do funkcji logowania, co umożliwia im 
personalizację doświadczenia na stronie.

Konto Administratora:
-Istnieje specjalne konto admina, które posiada dodatkowe uprawnienia.
Ustawienia admina pozwalają na zarządzanie treściami, użytkownikami i innymi aspektami 
strony.

Dodawanie Tagów:
Funkcja "Add Tag" umożliwia dodawanie tagów, które później są dostępne w zakładce "All tags".

Dodawanie Postów na Blogu:
Funkcja "Add Blog Post" pozwala użytkownikom dodawać nowe wpisy na bloga.
Podczas dodawania wpisu użytkownik ma możliwość wprowadzenia nagłówka, treści, 
zdjęcia, krótkiego opisu, daty publikacji i autora.

Wszystkie Wpisy na Blogu:
Zakładka "All Blog Posts" stanowi miejsce, gdzie użytkownicy mogą przeglądać wszystkie 
wpisy na blogu. Wpisy są wyświetlane w formie tablicy, umożliwiając łatwe przeglądanie treści.

Wylogowanie:
Funkcja "Logout" pozwala użytkownikom bezpiecznie wylogować się z obecnego konta.
Dzięki temu funkcji, dane logowania są zachowane w bazie danych, nawet po opuszczeniu strony.

Baza Danych:
Wszystkie konta są trwale zapisane w bazie danych, co gwarantuje trwałość danych 
użytkowników.
Informacje o blogach, tagach i innych treściach również są przechowywane w bazie danych, 
zapewniając spójność i łatwe zarządzanie treściami.

Projekt strony blogowej zapewnia kompleksowe funkcje zarządzania treściami oraz 
dostarcza użytkownikom intuicyjny interfejs do tworzenia, przeglądania i dzielenia się 
treściami na platformie

Opis Instalacji:
Konieczność edycji nazwy serwera w łańcuchu połączenia z bazą danych
Łańcuch połączenia z bazami danych:
    "BloggieDbConnectionString": "Server=Nazwa serwera;Database=BloggieDb;Trusted_Connection=True;TrustServerCertificate=Yes",
    "BloggieAuthDbConnectionString": "Server=Nazwa serwera;Database=BloggieAuthDb;Trusted_Connection=True;TrustServerCertificate=Yes"

Następnie konieczne jest zakutalizowanie i utworzenie bazy danych poniższymi komendami w konsoli menadżera pakietów

Update-Database -Context “BloggieDbContext”
Update-Database -Context -Context “AuthDbContext”

Użytkownicy i hasła:
Email: superadmin@blog.com
hasło: superadmin123
Konieczne ewentualne utworzenie poprzez Rejestracje nowego użytkownika
Username: user1@blog.com
Email: user1@blog.com
Hasło: User123!

