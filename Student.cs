//Fält: Name och en lista Courses.
//Method: join(course): går in i kursen
//Method Leave(course): lämnar kursen
//Method Schedule(): skriver ut vilka kurser den studerande går.
//ToString(): med den studerande namn


class Student(string studentName, string studentLast)
{
    public string StudentName = studentName;
    public string StudentLast = studentLast;


    public static string Join()
    {
        
    }
    public static string Leave()
    {
        
    }
    public static string Schedule()
    {
        
    }

    public override string ToString()
    {
        return $"{StudentName} {StudentLast}";
    }
}
