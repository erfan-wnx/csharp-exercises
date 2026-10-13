
using System;

// 1. Customer class
class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }

    public Customer(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Email: {Email}");
    }

    public void PlaceOrder()
    {
        Console.WriteLine($"{Name} placed an order.");
    }
}

// 2. Student class
class Student
{
    public string Name { get; set; }
    public int StudentId { get; set; }

    public Student(string name, int studentId)
    {
        Name = name;
        StudentId = studentId;
    }

    public void Introduce()
    {
        Console.WriteLine($"My name is {Name}");
    }

    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }
}

// 3. Teacher class
class Teacher
{
    public string Name { get; set; }
    public string Subject { get; set; }

    public Teacher(string name, string subject)
    {
        Name = name;
        Subject = subject;
    }

    public void Introduce()
    {
        Console.WriteLine($"Teacher: {Name}");
    }

    public void Teach()
    {
        Console.WriteLine($"{Name} teaches {Subject}.");
    }
}

// 4. Employee class
class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public void Work()
    {
        Console.WriteLine($"{Name} is working.");
    }

    public void ShowSalary()
    {
        Console.WriteLine($"Salary: {Salary}");
    }
}

// 5. Rectangle class
class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Area()
    {
        return Width * Height;
    }

    public double Perimeter()
    {
        return 2 * (Width + Height);
    }
}

// 6. Square class
class Square
{
    public double Side { get; set; }
    public string Color { get; set; }

    public Square(double side, string color)
    {
        Side = side;
        Color = color;
    }

    public double Area()
    {
        return Side * Side;
    }

    public double Perimeter()
    {
        return 4 * Side;
    }
}

// 7. Dog class
class Dog
{
    public string Name { get; set; }
    public string Breed { get; set; }

    public Dog(string name, string breed)
    {
        Name = name;
        Breed = breed;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} says Woof!");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Breed: {Breed}");
    }
}

// 8. Cat class
class Cat
{
    public string Name { get; set; }
    public string Color { get; set; }

    public Cat(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public void Meow()
    {
        Console.WriteLine($"{Name} says Meow!");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Color: {Color}");
    }
}

class Program
{
    static void Main()
    {
        // Customer
        Customer customer =
            new Customer("Ali", "ali@example.com");
        customer.ShowInfo();
        customer.PlaceOrder();

        // Student
        Student student = new Student("Sara", 101);
        student.Introduce();
        student.Study();

        // Teacher
        Teacher teacher = new Teacher("Reza", "Math");
        teacher.Introduce();
        teacher.Teach();

        // Employee
        Employee employee = new Employee("Mina", 2500);
        employee.Work();
        employee.ShowSalary();

        // Rectangle
        Rectangle rectangle = new Rectangle(4, 3);
        Console.WriteLine($"Rectangle area: {rectangle.Area()}");
        Console.WriteLine(
            $"Rectangle perimeter: {rectangle.Perimeter()}");

        // Square
        Square square = new Square(5, "Red");
        Console.WriteLine($"Square area: {square.Area()}");
        Console.WriteLine(
            $"Square perimeter: {square.Perimeter()}");

        // Dog
        Dog dog = new Dog("Max", "Labrador");
        dog.ShowInfo();
        dog.Bark();

        // Cat
        Cat cat = new Cat("Luna", "White");
        cat.ShowInfo();
        cat.Meow();
    }
}
