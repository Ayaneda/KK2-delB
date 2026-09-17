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
//Adds some students
Student aythami = new ("Aythami", "Yanez");
Student fede = new ("Federico", "Diaz");
Student marco = new ("Marcos", "Marrero");

//Adds some courses
Course matte = new ("Matte 1b", 2);
Course eng = new ("Engelska 5", 2);
Course sve = new ("Svenska 2", 2);


//just check if objects works
Console.WriteLine($"{aythami.FullName}");
Console.WriteLine($"{fede.FullName}");
Console.WriteLine($"{marco.FullName}");
Console.WriteLine($"{matte.NameOfCourse}");
Console.WriteLine($"{eng.NameOfCourse}");
Console.WriteLine($"{sve.NameOfCourse}");

//Check if student join a course
Console.WriteLine("\nCheck if student join a course\n-------------------");
aythami.Join(matte);
matte.RollCall();
aythami.Schedule();

//Check if another student join the course
Console.WriteLine("\nCheck if another student join the course\n-------------------");
aythami.Join(eng);
marco.Join(eng);
eng.RollCall();
aythami.Schedule();

//check if the student leave the course
Console.WriteLine("\nCheck if the student leave the course\n-------------------");
aythami.Leave(matte);
matte.RollCall();
aythami.Schedule();

//check if student enroll the course
Console.WriteLine("\nCheck if student enroll the course\n-------------------");
matte.Enroll(aythami);
aythami.Schedule();
matte.RollCall();

//Check if student is removed from course
Console.WriteLine("\nCheck if student is removed from course\n-------------------");
matte.Remove(aythami);
aythami.Schedule();
matte.RollCall();

//Check dubble join
Console.WriteLine("\nCheck double join\n-------------------");
aythami.Join(matte);
aythami.Join(matte);
aythami.Schedule();
matte.RollCall();
aythami.Leave(matte);


//Check double enroll
Console.WriteLine("\nCheck double enroll\n-------------------");
matte.Enroll(aythami);
matte.Enroll(aythami);
aythami.Schedule();
matte.RollCall();

 //Check to difference students and check max seats
 Console.WriteLine("\nCheck to difference students and check max seats\n-------------------");
 matte.Enroll(fede);
 matte.Enroll(marco);
 matte.RollCall();
 fede.Schedule();
 marco.Schedule();
 
//Check if using leave when is not attending the course already
 Console.WriteLine("\nCheck if using leave when is not attending the course already\n-------------------");
matte.Remove(marco);