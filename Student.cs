//Fält: Name och en lista Courses.
//Method: join(course): går in i kursen
//Method Leave(course): lämnar kursen
//Method Schedule(): skriver ut vilka kurser den studerande går.
//ToString(): med den studerande namn


class Student(string studentName, string studentLast)
{
    public string StudentName = studentName;
    public string StudentLast = studentLast;

    public string FullName = studentName + " " + studentLast;

    public List <Course> courses = [];
    



    public void Join(Course newcourse)
    {
        if (!courses.Contains(newcourse))
        {
            courses.Add(newcourse);
        }
    }
    public void Leave()
    {
        
    }
    public void Schedule()
    {
        
    }

    public override string ToString()
    {
        return $"{StudentName} {StudentLast}";
    }
}
