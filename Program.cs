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