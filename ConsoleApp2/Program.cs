//popros uzytkownika o podanie imienia
Console.WriteLine("Podaj swoje imie");
//deklarujemy nowa zmienna typu tekstowego o nazwie "name
string name = "";
//odczytamy od uzytkownika i zapiszemy do zmiennej imie - zapisz nieznajomy jesli uztykownik nie udzieli odpowiedzi
name = Console.ReadLine() ?? "Nieznajomy";
string greeting = "Witaj " + name + "!";
//wpisz gotowe powitanie
Console.WriteLine(greeting);
