using System;

public class Student
{

    protected string name;
    protected int age;

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void showInfo()
    {
        Console.WriteLine("Name: {0}, Age: {1}", name, age);
    }

}

public class StudentSSC : Student
{
    public StudentSSC(string name, int age) : base(name, age)
    {

    }
    public void ExtraClass()
    {
        Console.WriteLine("Extra Class for SSC");
    }
}
public class HSCStudent : Student
{
    public HSCStudent(string name, int age) : base(name, age) { }

    public void NightClass()
    {
        Console.WriteLine("Night Class");
    }
}

// class Teacher
// {
//     public string name;
//     public string subject;

//     public void showInfo()
//     {
//         Console.WriteLine("Name: {0}, Subject: {1}", name, subject);
//     }
// }

class Program
{
    public static void Main()
    {
        StudentSSC studentSSC = new StudentSSC("shakil", 20);
        studentSSC.showInfo();
        studentSSC.ExtraClass();

        HSCStudent hscStudent = new HSCStudent("shakib", 220);
        hscStudent.showInfo();
        hscStudent.NightClass();
    }
}