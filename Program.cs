using System;
using System.Collections.Generic;

class Student
{
    public string Name;
    public static int Count = 0;

    //constructors
    public Student(string name)
    {
        Name = name;
        Count++; //Increase count when a student is added.
    }

    public static void ShowInfo()
    {
        Console.WriteLine("The number of students are: "+ Count);
    }
}

class Nepal
{

    static void Main(string[] args)
    {
        Student student = new Student("Mahesh ");
        Student student1 = new Student("Rita");

        // call static method using class name
                Student.ShowInfo(); 
   }

 
}