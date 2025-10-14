// Task 4: Payment System

// Goal: Apply interfaces in a real-world example.
// · Create an interface IPaymentProcessor with:
//     o Method void ProcessPayment(decimal amount);
// · Implement:
//     o CreditCardPayment
//     o PayPalPayment
// · In Main(), ask user for a payment method and process a payment.
public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public class CreditCardPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing Credit Card payment of ${amount:F2}.");
    }
}

public class PayPalPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of ${amount:F2}.");
    }
}

// Task 5: Interface with Default Implementation (C# 8+)

// Goal: Explore default interface methods.
// · Create an interface ILogger with:
//      o Method void Log(string message);
//      o Default method void LogWithTime(string message) that logs with DateTime.Now.
// · Implement ILogger in a ConsoleLogger class.
// · Test both methods in Main().
public interface ILogger
{
    void Log(string message);

    void LogWithTime(string message)
    {
        Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
    }
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}

// Task 6: Polymorphism in Action

// Goal: Demonstrate how interfaces enable polymorphism.
// · Create an interface IShape with:
//      o Method double GetArea();
// · Implement:
//      o Rectangle (width × height)
//      o Circle (π × r²)
// · Create a List<IShape> and print total area of all shapes.
public interface IShape
{
    double GetArea();
}

public class Rectangle : IShape
{
    private double width { get; set; }
    private double height { get; set; }

    public Rectangle(double width, double height)
    {
        width = this.width;
        height = this.height;
    }

    public double GetArea()
    {
        return width * height;
    }

}

public class Circle : IShape
{
    private double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

}