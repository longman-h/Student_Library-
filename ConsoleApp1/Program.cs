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

        student1.GetOlder();
        student2.GetOlder();

        Console.WriteLine("Implementing student older");
        student1.Display();
        student2.Display();

        // Call the Book demo so book info is printed
        Book.Demo();
    }

    class Book
    {
        private string v1;
        private string v2;
        private string v3;

        public Book(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {v1}, Author: {v2}, ISBN: {v3}");
        }

        public static void Demo()
        {
            new Book("The Great Gatsby", "F. Scott Fitzgerald", "12345678").DisplayBookInfo();
        }
    }
}
