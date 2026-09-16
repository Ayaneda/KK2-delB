//Fält: Name och en lista Courses.
//Method: join(course): går in i kursen
//Method Leave(course): lämnar kursen
//Method Schedule(): skriver ut vilka kurser den studerande går.
//ToString(): med den studerande namn


class Student(string studentName, string studentLast) //Using primary constructor
{
    public string StudentName = studentName;
    public string StudentLast = studentLast;

    public string FullName = studentName + " " + studentLast;

    public List <Course> courses = [];
    



    public void Join(Course newCourse) //This is the method to join a course.
    {
        if (!courses.Contains(newCourse) && newCourse.Students.Count < newCourse.MaxSeats )
        {
            courses.Add(newCourse);
            newCourse.Students.Add(this);
            Console.WriteLine($"{FullName} has been registered in {newCourse.NameOfCourse}");
        }

    }
    public void Leave(Course leaveCourse)
    {
        {
        if (courses.Contains(leaveCourse) )
        {
            courses.Remove(leaveCourse);
            leaveCourse.Students.Remove(this);
            Console.WriteLine($"{FullName} has been unregistered from {leaveCourse.NameOfCourse}");
        }
    }
    }
    public void Schedule()
    {
        Console.WriteLine($"{FullName} is assisting: ");
        foreach (Course c in courses)
        {
            Console.WriteLine($"{c}");
        }
    }

    public override string ToString()
    {
        return $"{StudentName} {StudentLast}";
    }
}
