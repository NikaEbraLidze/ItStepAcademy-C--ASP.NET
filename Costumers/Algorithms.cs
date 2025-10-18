using static Input;

public static class CustomerProcessor
{
    public static Customer[] GetAllCustomers(string filePath)
    {
        string[] data = File.ReadAllLines(filePath);
        List<Customer> customersList = new List<Customer>();

        bool isHeader = true;
        foreach (string line in data)
        {
            if (isHeader)
            {
                isHeader = false;
                continue;
            }

            try
            {
                Customer p = Customer.Parse(line.Trim());
                customersList.Add(p);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Skipping invalid record: '{line.Trim()}' - Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Skipping record with invalid number format: '{line.Trim()}' - Error: {ex.Message}");
            }
        }

        return customersList.ToArray();
    }

    public static Customer GetSingleCustomer(Customer[] customersArr, int customerId)
    {
        foreach (Customer p in customersArr)
        {
            if (p.Id == customerId)
                return p;
        }

        throw new InvalidOperationException($"Customer with ID {customerId} was not found in the data source.");
    }

    public static void AddCustomer(Customer customer, string filePath)
    {
        if (customer == null)
        {
            throw new ArgumentNullException(nameof(customer), "Cannot add a null customer object to the file.");
        }

        Customer[] customersArr = GetAllCustomers(filePath);
        foreach (Customer p in customersArr)
        {
            if (p.Id == customer.Id)
                throw new ArgumentException("Id must be unique, try again");
        }

        try
        {
            string csvLine = customer.ToCsvString();

            string lineToWrite = csvLine + Environment.NewLine; // + ის შემდეგ რაც არის gemini მ მასწავლაა რომ ახალ ხაზზე გადავიდეს

            File.AppendAllText(filePath, lineToWrite);

            Console.WriteLine($"Successfully added Customer ID {customer.Id} to {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    public static void LogArr(Customer[] arr)
    {
        foreach (Customer p in arr)
        {
            Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, IdentityNumber: {p.IdentityNumber}, PhoneNumber: {p.PhoneNumber}, Email: {p.Email}, Type: {p.Type}");
        }
    }

    public static bool CheckIfUserExist(Customer[] customersArr, int UpdateCustomerId)
    {
        bool isUserExist = false;
        foreach (Customer p in customersArr)
        {
            if (UpdateCustomerId == p.Id)
            {
                isUserExist = true;
                p.Log();
            }
        }

        return isUserExist;
    }

    public static void UpdateCustomerInfo(Customer[] customersArr, int newCustmerId)
    {
        Customer updatedCustomer = CreateCustomer(customersArr, newCustmerId);
        try
        {
            foreach (Customer p in customersArr)
            {
                if (updatedCustomer.Id == p.Id)
                {
                    p.Id = updatedCustomer.Id;
                    p.Name = updatedCustomer.Name;
                    p.IdentityNumber = updatedCustomer.IdentityNumber;
                    p.Email = updatedCustomer.Email;
                    p.PhoneNumber = updatedCustomer.PhoneNumber;
                    p.Type = updatedCustomer.Type;
                }
            }
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    public static Customer[] DeleteCustomerById(Customer[] customersArr, int deleteId)
    {
        try
        {
            Customer[] updatedCustomers = customersArr
                .Where(c => c.Id != deleteId)
                .ToArray();

            Console.WriteLine("User Deleted Successfully.");

            return updatedCustomers;
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Error deleting user: " + ex.Message);
        }
    }


    public static string[] ToCsvLines(Customer[] customers, bool includeHeader = true)
    {
        List<string> csvLines = new List<string>();
        if (includeHeader)
        {
            csvLines.Add("Id,Name,IdentityNumber,PhoneNumber,Email,Type");
        }

        if (customers != null)
        {
            foreach (Customer customer in customers)
            {
                string csvLine = customer.ToCsvString();
                csvLines.Add(csvLine);
            }
        }

        return csvLines.ToArray();
    }

    public static void SaveCustomersToCsv(string filePath, Customer[] customers, bool includeHeader = true)
    {
        string[] csvLines = ToCsvLines(customers, includeHeader);

        File.WriteAllLines(filePath, csvLines);
        Console.WriteLine("Data updated successfully.");
    }
}