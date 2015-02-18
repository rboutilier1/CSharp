using System;

class GradeBookTest
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hellooo!");
        GradeBook myGradeBook1 = new GradeBook( "CS 101 Computer Science" );
        GradeBook myGradeBook2 = new GradeBook("CS 201 Computer Science");
        //myGradeBook.CourseName = "Intercourse 101";
        //Console.WriteLine("Initial course name is: {0}\n",myGradeBook.CourseName);
        //Console.WriteLine("Please enter a new course name:");
        //myGradeBook.CourseName = Console.ReadLine();
        //Console.WriteLine();
        myGradeBook1.DisplayMessage();
        Console.WriteLine();
        myGradeBook2.DisplayMessage();
    }
}
