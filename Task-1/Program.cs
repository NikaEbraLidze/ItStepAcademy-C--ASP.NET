using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        /////////////////////// Level 1 /////////////////////
        ///////////////////// Task 1 /////////////////
        List<IAnimal> animals = new List<IAnimal>
            {
                new Dog(),
                new Cat()
            };

        foreach (IAnimal animal in animals)
        {
            animal.MakeSound();
        }

        ///////////////////// Task 2 /////////////////
        Car car = new Car();
        car.Model = "Porshe";
        car.Year = 2025;
        car.Start();

        ///////////////////// Task 3 /////////////////
        Document doc = new();
        doc.Read();
        doc.Write();



        /////////////////////// Level 2 /////////////////////
        ///////////////////// Task 4 //////////////////
        IPaymentProcessor processor;
        decimal paymentAmount = 100.50m;

        Console.Write("Enter payment method (CreditCard/PayPal): ");
        string method = Console.ReadLine()?.Trim();

        if (method?.Equals("CreditCard", StringComparison.OrdinalIgnoreCase) == true)
        {
            processor = new CreditCardPayment();
        }
        else if (method?.Equals("PayPal", StringComparison.OrdinalIgnoreCase) == true)
        {
            processor = new PayPalPayment();
        }
        else
        {
            Console.WriteLine("Invalid payment method selected.");
            return;
        }
        processor.ProcessPayment(paymentAmount);



        ///////////////////// Task 5 //////////////////
        ILogger logger = new ConsoleLogger();

        logger.Log("Simple message logged.");
        logger.LogWithTime("Timed message logged using default implementation.");



        ///////////////////// Task 6 //////////////////
        List<IShape> shapes = new List<IShape>
        {
            new Rectangle(10, 5),
            new Circle(3),
            new Rectangle(2, 2)
        };

        double totalArea = 0;

        foreach (IShape shape in shapes)
        {
            totalArea += shape.GetArea();
        }

        Console.WriteLine($"Total area of all shapes: {totalArea:F2}");
    }
}