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


class program
{
    public static void Main()
    {
        Student student1 = new Student();
        student1.name = "John";
        student1.age = 20;

        Student student2 = new Student();
        student2.name = "Jane";
        student2.age = 21;

        student1.showInfo();
    }
}