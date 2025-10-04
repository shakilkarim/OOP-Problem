using System;


class Student
{
    public string name;
    public int age;

    public void showInfo()
    {
        Console.WriteLine("Name: {0}, Age: {1}", name, age);
    }

}
class Program
{
    public static void Main()
    {
        Student student1 = new Student();
        student1.name = "John";
        student1.age = 20;
        student1.showInfo();
    }
}