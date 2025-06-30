# Student Inheritance Example in C#

This is a simple C# console application that demonstrates the concept of inheritance and method overriding in object-oriented programming. The example simulates a `Student` base class and a derived class `Karekezi` that extends its functionality.

## Key Concepts Demonstrated

- Class Inheritance
- Virtual and Override Methods
- Object Initialization
- Accessing Base Class Members

## Project Structure

```

StudentInheritanceExample/
├── Program.cs
└── README.md

```

## How to Run the Project

### Option 1: Clone and Run

1. Clone the repository:

```

git clone [https://github.com/yourusername/StudentInheritanceExample.git](https://github.com/yourusername/StudentInheritanceExample.git)
cd StudentInheritanceExample

```

2. Run the project:

```

dotnet run

```

17. Expected output:

```

Student Name: Emmanuel, Age: 17
Karekezi speaks Kinyarwanda
Emmanuel is a basketball player!
Karekezi's name is Emmanuel and is 17 years old.

```

### Option 2: Create the Project Manually

1. Open a terminal.

2. Create a new .NET console project:

```

dotnet new console -n StudentInheritanceExample
cd StudentInheritanceExample

````

17. Replace the contents of `Program.cs` with the following code:

```csharp
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
 public override void Speak()
 {
     Console.WriteLine("Karekezi speaks Kinyarwanda");
 }

 public void Fetch()
 {
     Console.WriteLine($"{Name} is a basketball player!");
 }

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
         Name = "Emmanuel",
         Age = 17
     };

     myKarekezi.DisplayInfo();
     myKarekezi.Speak();
     myKarekezi.Fetch();
     myKarekezi.KarekeziInfo();
 }
}
````

4. Run the program:

   ```
   dotnet run
   ```

## Author

Daniel Iryivuze
Software Developer
Kigali, Rwanda

```
