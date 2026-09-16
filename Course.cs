//Fält: Name, en kapacitet(max seats), lista av students.
//Method: Enroll(student): anmäler en studerande till kursen, om det finns plats 
//Method: Remove(student): ta bort student.
//Method: RollCall(): skriver ut alla studerande i kursen.
//En toString() som ger tex. Matematik(2/5 platser)
using System.Formats.Asn1;
using System.Reflection;
using System.Runtime.CompilerServices;

class Course(string nameOfCourse, int maxSeats) //This will be the class structure for Course class
{
    public string NameOfCourse = nameOfCourse;
    public int MaxSeats = maxSeats;
    public List<Student> Students = [];

    public void Enroll(Student newStudent) //add student in a course
    {
        if (!Students.Contains(newStudent))
        {
            if (Students.Count < MaxSeats)
            {
                newStudent.Join(this);    
                Students.Add(newStudent);
                Console.WriteLine($"The {newStudent} have been registered.");
            }
    
            
        }
        else
        {
            Console.WriteLine($"{newStudent} is already or there wasn't any available spots.");
        }    
    }

    public void Remove(Student newStudent)
    {
        if (Students.Contains(newStudent))
        {
            newStudent.Leave(this);
            Students.Remove(newStudent);
            Console.WriteLine($"{newStudent} has been remove from the {this} course.");
        }
        
    }

    public void RollCall()
    {
        Console.WriteLine($"In {this} are assisting the following students: ");
        foreach (Student s in Students)
        {
            Console.WriteLine($"{s}");
        }
    }
    public override string ToString()
    {
        return $"{NameOfCourse} ({Students.Count}/{MaxSeats} platser)";
    }
}