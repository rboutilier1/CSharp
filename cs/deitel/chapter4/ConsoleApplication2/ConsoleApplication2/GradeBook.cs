using System;


class GradeBook
{
    private string courseName;

    public string CourseName { get; set; }
    /*
    public string CourseName
    {
        get
        {
            return courseName;
        }
        set
        {
            courseName = value;
        }
    }
     * */
    public GradeBook( string name)
    {
        CourseName = name;
    }
    public void DisplayMessage()
    {
        Console.WriteLine("Welcome to the GradeBook for {0}!", CourseName);
    }
}

