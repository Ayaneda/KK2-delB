//Fält: Name, en kapacitet(max seats), lista av students.
//Method: Enroll(student): anmäler en studerande till kursen, om det finns plats 
//Method: Remove(student): ta bort student.
//Method: RollCall(): skriver ut alla studerande i kursen.
//En toString() som ger tex. Matematik(2/5 platser)
using System.Formats.Asn1;
using System.Reflection;
using System.Runtime.CompilerServices;

class Course(string nameOfCourse, int maxSeats) //This will be the class structure for Course class using primary contructors.
{
    
    public string NameOfCourse = nameOfCourse;  //Name of the course
    public int MaxSeats = maxSeats; //Limiting spots for the course
    public List<Student> Students = []; //list to save students in course

    public void Enroll(Student newStudent) 
    //add student in a course. If-syntax to give rules. 
    //Giving feedbacks message for easy tracking of what is happening  
    {
        if (Students.Contains(newStudent)) //checking in the list if the students is already in the course.
        {
            Console.WriteLine($"{newStudent} is already attending {this}");
        }
        else if (Students.Count >= MaxSeats) //checking max spots in the course
        {
            Console.WriteLine($"Sorry {newStudent}, {this} doesn't have more spots.");
        }   
        
        else //if everything is check, then student can join this
        {
            Students.Add(newStudent); //Adding this student in the list of course class.
            newStudent.courses.Add(this);     //Adding course in the course list
            Console.WriteLine($"{newStudent} have been registered.");
        }    
    }

    public void Remove(Student newStudent)  //Method to remove student from a course using the method from student class
    {
        if (Students.Contains(newStudent)) //If there is a student attending this course, then 
        {
            newStudent.Leave(this);
            Console.WriteLine($"{newStudent} has been remove from the {this} course.");
        }
        else  //If there isn't any student, feedback.
        {
            Console.WriteLine($"{newStudent} is not attending {this}.");
        }
        
    }

    public void RollCall() // Just a record for how many are attending.
    {
        if(Students.Count == 0) //If there isn't any student- feedback.
        {
            Console.WriteLine($"{this} doesn't have any students yet.");
        }
        else  //if there is any, it gives the names of students.
        {
            Console.WriteLine($"{this} has the following students: ");
            foreach (Student s in Students)
            {
                Console.WriteLine($"{s}");
            }
        }
    }
    public override string ToString() //message when obj is called.
    {
        return $"{NameOfCourse} ({Students.Count}/{MaxSeats} platser)";
    }
}