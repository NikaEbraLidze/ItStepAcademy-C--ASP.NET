
public static class VehicleProcessor
{
    public static Vehicle[] ReadAllData(string filePath)
    {
        string[] data = File.ReadAllLines(filePath);

        List<Vehicle> vehiclesList = new List<Vehicle>();

        bool isHeader = true;
        foreach (string car in data)
        {
            if (isHeader)
            {
                isHeader = false;
                continue;
            }

            try
            {
                Vehicle vehicle = Vehicle.Parse(car.Trim());
                vehiclesList.Add(vehicle);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Skipping invalid record: '{car.Trim()}' - Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Skipping record with invalid number format: '{car.Trim()}' - Error: {ex.Message}");
            }
        }

        return vehiclesList.ToArray();
    }

    public static Vehicle[] SearchCarByModel(Vehicle[] vehiclesList, string Model)
    {
        List<Vehicle> mercedesList = new List<Vehicle>();

        foreach (Vehicle car in vehiclesList)
        {
            if (car.Make == Model)
                mercedesList.Add(car);
            else
                continue;
        }

        return mercedesList.ToArray();
    }

    public static void LogArr(Vehicle[] arr)
    {
        foreach (Vehicle item in arr)
        {
            Console.WriteLine($"Make: {item.Make}, Model: {item.Model}, Engine: {item.Engine}L, Combined MPG: {item.Combined}");
        }
    }

    public static Vehicle[] SortItemsByCombined(Vehicle[] vehiclesList)
    {
        for (int i = 0; i < vehiclesList.Length - 1; i++)
        {
            for (int j = i + 1; j < vehiclesList.Length; j++)
            {
                if (vehiclesList[j].Combined > vehiclesList[i].Combined)
                {
                    Vehicle temp = vehiclesList[j];
                    vehiclesList[j] = vehiclesList[i];
                    vehiclesList[i] = temp;
                }
            }
        }

        return vehiclesList;
    }

    public static Vehicle[] FindEconomicCars(Vehicle[] vehiclesList, int quantity)
    {
        if (quantity > vehiclesList.Length)
            throw new ArgumentException("Quantity can't exceed vehicles length");

        Vehicle[] vehicles = SortItemsByCombined(vehiclesList);

        Vehicle[] result = new Vehicle[quantity];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = vehicles[i];
        }

        return result;
    }
}