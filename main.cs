using System;

// public class Student
// {

//     protected string name;
//     protected int age;

//     public Student(string name, int age)
//     {
//         this.name = name;
//         this.age = age;
//     }
//     public void showInfo()
//     {
//         Console.WriteLine("Name: {0}, Age: {1}", name, age);
//     }

// }

// public class StudentSSC : Student
// {
//     public StudentSSC(string name, int age) : base(name, age)
//     {

//     }
//     public void ExtraClass()
//     {
//         Console.WriteLine("Extra Class for SSC");
//     }
// }
// public class HSCStudent : Student
// {
//     public HSCStudent(string name, int age) : base(name, age) { }

//     public void NightClass()
//     {
//         Console.WriteLine("Night Class");
//     }
// }

// class Teacher
// {
//     public string name;
//     public string subject;

//     public void showInfo()
//     {
//         Console.WriteLine("Name: {0}, Subject: {1}", name, subject);
//     }
// }
//Polymorphism overloading exmaple
class QuizProperties
{
    public void Quiz()
    {
        Console.WriteLine("Normal Quiz");
    }
    public void Quiz(int time)
    {
        Console.WriteLine("MCQ Quiz", time);
    }
    public void Quiz(int time, string topic)
    {
        Console.WriteLine("Hard Quiz", time, topic);
    }
}

//Ploymorphism overwriting example
public class Course
{
    public virtual void ShowDetails()
    {
        Console.WriteLine("Course Details");
    }

}

public class CSharp : Course
{
    public override void ShowDetails()
    {
        Console.WriteLine("C# Course Details");
    }
}

class Program
{
    public static void Main()
    {
        // StudentSSC studentSSC = new StudentSSC("shakil", 20);
        // studentSSC.showInfo();
        // studentSSC.ExtraClass();

        // HSCStudent hscStudent = new HSCStudent("shakib", 220);
        // hscStudent.showInfo();
        // hscStudent.NightClass();

        // QuizProperties quiz = new QuizProperties();
        // quiz.Quiz();
        // quiz.Quiz(30);
        // quiz.Quiz(30, "C#");

        CSharp course = new CSharp();
        course.ShowDetails();
    }
}