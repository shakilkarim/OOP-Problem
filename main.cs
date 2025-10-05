using System;

class Student
{

    public string name;
    public int age;
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
        Student student1 = new Student("shakil", 20);

        student1.showInfo();
    }
}