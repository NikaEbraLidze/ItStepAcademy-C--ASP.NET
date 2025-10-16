public interface IVehicle
{
    string Make { get; }
    string Model { get; }
    int Cylinder { get; }
    double Engine { get; }
    string Drive { get; }
    string Transmission { get; }
    int City { get; }
    int Combined { get; }
    int Highway { get; }
}

public class Vehicle : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Cylinder { get; set; }
    public double Engine { get; set; }
    public string Drive { get; set; }
    public string Transmission { get; set; }
    public int City { get; set; }
    public int Combined { get; set; }
    public int Highway { get; set; }

    public Vehicle(string make, string model, string cylinder, string engine, string drive, string transmission, string city, string combined, string highway)
    {
        Make = make;
        Model = model;
        Cylinder = int.Parse(cylinder);
        Engine = double.Parse(engine);
        Drive = drive;
        Transmission = transmission;
        City = int.Parse(city);
        Combined = int.Parse(combined);
        Highway = int.Parse(highway);
    }

    public static Vehicle Parse(string input)
    {
        string[] data = input.Split(',');

        if (data.Length != 9)
            throw new ArgumentException("Invalid input!");

        Vehicle result = new Vehicle(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8]);

        return result;
    }
}
