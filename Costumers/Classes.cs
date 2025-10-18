using static CustomerValidator;
using static CustomerProcessor;

public class Customer
{
    public int Id { get; set; }
    private string name;
    private string identityNumber;
    private string phoneNumber;
    private string email;
    public byte Type { get; set; }

    public string Name
    {
        get { return name; }
        set
        {
            ValidateName(value);
            name = value;
        }
    }
    public string IdentityNumber
    {
        get { return identityNumber; }
        set
        {
            ValidateIdentityNumber(value);
            identityNumber = value;
        }
    }
    public string PhoneNumber
    {
        get { return phoneNumber; }
        set
        {
            ValidatePhoneNumber(value);
            phoneNumber = value;
        }
    }
    public string Email
    {
        get { return email; }
        set
        {
            ValidateEmail(value);
            email = value;
        }
    }

    public Customer(int id, string name, string identityNumber, string phoneNumber, string email, byte type)
    {
        Id = id;
        Name = name;
        IdentityNumber = identityNumber;
        PhoneNumber = phoneNumber;
        Email = email;
        Type = type;
    }

    public void Log()
    {
        Console.WriteLine($"Id: {this.Id}, Name: {this.Name}, IdentityNumber: {this.IdentityNumber}, Phonenumber: {this.PhoneNumber}, Email: {this.Email} Type: {this.Type}");
    }

    public string ToCsvString()
    {
        return $"{Id},{Name},{IdentityNumber},{PhoneNumber},{Email},{Type}";
    }

    public static Customer Parse(string input)
    {
        string[] data = input.Split(',');

        if (data.Length != 6)
            throw new ArgumentException("Invalid input!");

        Customer result = new Customer(int.Parse(data[0]), data[1], data[2], data[3], data[4], byte.Parse(data[5]));

        return result;
    }
}


public static class Input
{
    public static string ReadString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    public static Customer CreateCustomer(Customer[] customersArr, int? id = null)
    {
        Console.WriteLine("Entering Customer Data");

        int nextId = id ?? ((customersArr != null && customersArr.Length > 0) ? customersArr.Length + 1 : 1);
        Console.WriteLine($"Customer ID: {nextId}");

        string name = ReadString("Enter Name: ");
        string identityNumber = ReadString("Enter Identity Number (e.g., 11 digits): ");
        string phoneNumber = ReadString("Enter Phone Number (e.g., 9 digits): ");
        string email = ReadString("Enter Email: ");
        string typeStr = ReadString("Enter Type (0 for Individual, 1 for Legal Entity): ");

        byte type = 0;
        try
        {
            type = byte.Parse(typeStr);
        }
        catch (FormatException)
        {
            Console.WriteLine("[WARNING]: Invalid type entered. Defaulting to 0 (Individual).");
        }

        Customer newCustomer = new Customer(
            id: nextId,
            name: name,
            identityNumber: identityNumber,
            phoneNumber: phoneNumber,
            email: email,
            type: type
        );

        return newCustomer;
    }

    public static void UpdateCustomer(Customer[] customersArr, string filePath)
    {
        try
        {
            int UpdateCustomerId = int.Parse(ReadString("Enter the user ID you want to change."));

            if (!CheckIfUserExist(customersArr, UpdateCustomerId))
                throw new ArgumentException("User Not Found");

            UpdateCustomerInfo(customersArr, UpdateCustomerId);

            SaveCustomersToCsv(filePath, customersArr);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void DeleteCustomer(Customer[] customersArr, int customerId, string filePath)
    {
        if (!CheckIfUserExist(customersArr, customerId))
            throw new ArgumentException("User Not Found");

        Customer[] newData = DeleteCustomerById(customersArr, customerId);
        SaveCustomersToCsv(filePath, newData);
    }
}