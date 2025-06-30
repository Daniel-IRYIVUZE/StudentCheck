using System;

// Base class
public class Student
{
    public string Name;
    public int Age;

    public void DisplayInfo()
    {
        Console.WriteLine($"Student Name: {Name}, Age: {Age}");
    }

    public virtual void Speak()
    {
        Console.WriteLine("Student speaks");
    }
}

// Derived class
public class Karekezi : Student
{
    // Override virtual method
    public override void Speak()
    {
        Console.WriteLine("Karekezi speaks Kinyarwanda");
    }

    // Custom method
    public void Fetch()
    {
        Console.WriteLine($"{Name} is a basketball player!");
    }

    // Using base‑class variables
    public void KarekeziInfo()
    {
        Console.WriteLine($"Karekezi's name is {Name} and is {Age} years old.");
    }
}

// Main program
public class Program
{
    public static void Main()
    {
        Karekezi myKarekezi = new Karekezi
        {
            Name = "Emmanuel Karekezi",
            Age = 17
        };

        myKarekezi.DisplayInfo();   // Base‑class method
        myKarekezi.Speak();         // Overridden method
        myKarekezi.Fetch();         // Custom method
        myKarekezi.KarekeziInfo();  // Uses base variables
    }
}
