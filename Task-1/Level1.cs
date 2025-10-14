// Task 1: Create and Implement an Interface

// Goal: Understand how to define and implement an interface.
// · Create an interface called IAnimal with:
//     o Method void MakeSound();
// · Create two classes:
//     o Dog → prints "Woof!"
//     o Cat → prints "Meow!"
// · In Main(), create a list of IAnimal and call MakeSound() on each.

public interface IAnimal
{
    public void MakeSound();
}

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.Write("Woof!");
    }
}

public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.Write("Meow!");
    }
}

// Task 2: Interface with Properties

// Goal: Learn to use properties in interfaces.
// · Create an interface IVehicle with:
//     o Property string Model { get; set; }
//     o Property int Year { get; set; }
//     o Method void Start();
// · Implement it in a class Car.
// · In Main(), create a Car, assign model/year, and call Start()
public interface IVehicle
{
    protected string Model { get; set; }
    protected int Year { get; set; }
    void Start();
}

public class Car : IVehicle
{
    public string Model { get; set; }
    public int Year { get; set; }
    public void Start()
    {
        Console.Write($"The {Year} {Model} car is starting its engine.");
    }
}

// Task 3: Multiple Interfaces

// Goal: Learn multiple interface implementation.
// · Create two interfaces:
//     o IReadable → method void Read()
//     o IWritable → method void Write()
// · Implement both in a class Document.
// · In Main(), call both methods on a Document object.

public interface IReadable
{
    void Read();
}

public interface IWritable
{
    void Write();
}

public class Document : IReadable, IWritable
{
    public void Read()
    {
        Console.WriteLine("Document is being read.");
    }
    public void Write()
    {
        Console.WriteLine("Document is being written/edited.");
    }

}