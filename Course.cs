//Fält: Name, en kapacitet(max seats), lista av students.
//Method: Enroll(student): anmäler en studerande till kursen, om det finns plats 
//Method: Remove(student): ta bort student.
//Method: RollCall(): skriver ut alla studerande i kursen.
//En toString() som ger tex. Matematik(2/5 platser)
using System.Runtime.CompilerServices;

class Course() //This will be the class structure for Course class
{
    public string NameOfCourse = nameOfCourse;
    public int MaxSeats = maxSeats;
    public List<string> students = [];

    public static string Enroll(string Student)
    {
        
    }

    public static string Remove(string Student)
    {
        
    }

    public static string RollCall(string Student)
    {
        
    }
    public override string ToString()
    {
        return $"{NameOfCourse} ({students.Count}/{MaxSeats} platser)";
    }
}