/* Reglerna som gör uppgiften:
Båda hållen ska alltid stämma: Anmäler du en studerande till en kurs (oavsett om du gör det via
kursens Enroll eller den studerandes Join) ska studeranden hamna i kursens Students och kursen i
studerandens Courses. Samma sak vid borttagning.
Inga dubletter. Samma studerande får inte hamna två gånger i en kurs, hur många gånger man än
anmäler.
Kapacitet. En kurs kan inte ta in fler än MaxSeats studerande — säg till (t.ex. "Kursen är full") i stället
för att lägga till.
Ingen krasch får ske om man försöker ta bort en studerande som inte är anmäld.


I DETTA FILEN: Skapa några kurser och några studerande, anmäl och avanmäl dem åt olika håll, och
skriv ut med RollCall() och Schedule() så att det syns att båda hållen hänger ihop och att reglerna
ovan fungerar (t.ex. att en full kurs säger nej, och att dubbelanmälan inte ger dubbletter)
*/

Student aythami = new ("Aythami", "Yanez");
Student fede = new ("Federico", "Diaz");
Student marco = new ("Marcos", "Marrero");


Course matte = new ("Matte 1b", 5);
Course eng = new ("Engelska 5", 5);
Course sve = new ("Svenska 2", 5);



Console.WriteLine($"{aythami.FullName}");
Console.WriteLine($"{fede.FullName}");
Console.WriteLine($"{marco.FullName}");
Console.WriteLine($"{matte.NameOfCourse}");
Console.WriteLine($"{eng.NameOfCourse}");
Console.WriteLine($"{sve.NameOfCourse}");

aythami.Join(matte);
matte.RollCall();
aythami.Schedule();
aythami.Join(eng);
eng.RollCall();
aythami.Schedule();
aythami.Leave(matte);
matte.RollCall();
aythami.Schedule();

