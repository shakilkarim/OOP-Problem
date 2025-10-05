using System;

class StudentNew
{

    public string name;
    public int age;

    //Set setter 
    public void setName(string name){
        this.name = name;
    }
    //get getter
    public string getName(){
        return this.name;
    }
    public void setAge(int age){
        this.age = age;
        
    }
    //get getter
    public int getAge(){
        return this.age;
    }
    

}



class HelloWorld
{
    public static void Main()
    {
        StudentNew student1 = new StudentNew();
        student1.setName("shakil");
        student1.setAge(20);
        Console.WriteLine("Name:{0} ,Age:{1}",student1.getName(),student1.getAge());
    }
}