using System;

public class Student
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Student() : this("Unknown", 0) { }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    public void GetOlder()
    {
        Age++;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        Student student2 = new Student("Jane Doe", 18);

        student1.Display();
        student2.Display();

        // Implement GetOlder
        student1.GetOlder();
        student2.GetOlder();

        Console.WriteLine("Implementing student older");
        student1.Display();
        student2.Display();
    }

}
