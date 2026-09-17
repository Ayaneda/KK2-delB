//Fält: Name och en lista Courses.
//Method: join(course): går in i kursen
//Method Leave(course): lämnar kursen
//Method Schedule(): skriver ut vilka kurser den studerande går.
//ToString(): med den studerande namn


class Student(string studentName, string studentLast) //Using primary constructor
{
    public string StudentName = studentName;
    public string StudentLast = studentLast;

    public string FullName = studentName + " " + studentLast; //Just making a more realistic case.

    public List <Course> courses = []; // list to keep track about how many courses are objects attending
    



    public void Join(Course newCourse) //This is the method to join a course.
    {
    if (courses.Contains(newCourse))  //Checking double attending.
        {
            Console.WriteLine($"{this} is already attending {newCourse}");
        }
    else if (newCourse.Students.Count >= newCourse.MaxSeats)  //it controls the capacity of the course
        {
            Console.WriteLine($"Sorry {this}, {newCourse} is full.");
        }
    else
    {
        newCourse.Students.Add(this); //Adding this student in the list of course class.
        courses.Add(newCourse);     //Adding course in the course list
        Console.WriteLine($"{FullName} has been registered in {newCourse.NameOfCourse}"); //Just giving a feedback for easy tracking.

    }

    }
    public void Leave(Course leaveCourse) //method for leave a course
    {
        if (courses.Contains(leaveCourse)) //Check if it's attending this course.
        {
            leaveCourse.Students.Remove(this);  //Remove student from course class list.
            courses.Remove(leaveCourse);        //Remove from course list
            Console.WriteLine($"{FullName} has been unregistered from {leaveCourse.NameOfCourse}"); //Feedback
        }
        else  //If the student is not attending, then feedback
        {
            Console.WriteLine($"{this} wasn't in the {leaveCourse} course from the begining."); //Feedback
        }
    }
    public void Schedule() //a record of the course this students is attending 
    {
        
        if (courses.Count == 0)  //If there isnt any course, feedback
        {
            Console.WriteLine($"{FullName} are not attending any course yet.");
        }
        else  //Giving a record of the course attending.
        {
            Console.WriteLine($"{FullName} is attending: ");
            foreach (Course c in courses)
            {
                Console.WriteLine($"{c}");
            }
        }
        
    }

    public override string ToString()  //message when obj is called
    {
        return $"{FullName}";
    }
}
