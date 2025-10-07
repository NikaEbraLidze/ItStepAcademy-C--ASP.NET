using System;
using System.Security.Cryptography.X509Certificates;


// მოახდინეთ ვალიდაციები Human კლასისთვის ქვევით მითითებული პირობების მიხედვით. 
// ვალიდაციისათვის გამოიყენეთ Full Property
public class Human
{
    //სავალდებულო | მაქსიმუმ ზომა 50
    private string _firstName;
    public string FirstName
    {
        get { return _firstName; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length < 50)
                _firstName = value;
            else
                throw new ArgumentException("First name must be between 1 and 50 characters.");
        }
    }

    //სავალდებულო | მაქსიმუმ ზომა 50
    private string _lastName;
    public string LastName
    {
        get { return _lastName; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length < 50)
                _lastName = value;
            else
                throw new ArgumentException("First name must be between 1 and 50 characters.");
        }
    }

    //სავალდებულო | დადებითი
    private byte _age;
    public byte Age
    {
        get { return _age; }
        set
        {
            if (value > 0)
                _age = value;
            else
                throw new ArgumentException("Age must be greater than 0");
        }
    }

    //სავალდებულო | ზუსტად 11 ზომაში
    private string _personalNumber;
    public string PersonalNumber
    {
        get { return _personalNumber; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Personal number is required.");
            else if (value.Length != 11)
                throw new ArgumentException("Personal number must be exactly 11 digits.");
            else if (!value.All(char.IsDigit))
                throw new ArgumentException("Personal number must contain only digits.");

            _personalNumber = value;
        }
    }

    //სავალდებულო | ზუსტად 9 ზომაში
    private string _phoneNumber;
    public string PhoneNumber
    {
        get { return _phoneNumber; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Phone number is required.");
            else if (value.Length != 11)
                throw new ArgumentException("Phone number must be exactly 9 digits.");
            else if (!value.All(char.IsDigit))
                throw new ArgumentException("Phone number must contain only digits.");

            _phoneNumber = value;
        }
    }

    //სავალდებულო უნდა ერიოს @ . |  არ უნდა იწყებოდეს @ . |  არ უნდა მთავრდებოდეს @ . | . არ უნდა იჯდეს @ წინ
    private string _email;
    public string Email
    {
        get { return _email; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Email is required.");
            else if (!value.Contains('@') || !value.Contains('.'))
                throw new ArgumentException("Email must contain '@' and '.' characters.");
            else if (value.StartsWith("@") || value.StartsWith("."))
                throw new ArgumentException("Email cannot start with '@' or '.'.");
            else if (value.EndsWith("@") || value.EndsWith("."))
                throw new ArgumentException("Email cannot end with '@' or '.'.");

            int atIndex = value.IndexOf('@');
            int dotIndex = value.LastIndexOf('.');

            if (dotIndex < atIndex)
                throw new ArgumentException("'.' cannot appear before '@'.");

            _email = value;
        }
    }

    public Human(string firstName, string lastName, byte age, string personalNumber, string phoneNumber, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        PersonalNumber = personalNumber;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public void DisplayInfoInConsole()
    {
        Console.WriteLine($"{FirstName} {LastName} {Age} {PersonalNumber} {PhoneNumber} {Email}");
    }
}


// დაწერეთ ანგარიშს კლასი, რომელსაც ექნება
//      • ანგარიშის ნომერი (22 ნიშნა)
//      • ვალუტა(სამნიშნა)
//      • ბალანსი(არ უნდა იყოს უარყოფითი)
public class Account
{
    private string _accountNumber;
    public string AccountNumber
    {
        get { return _accountNumber; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Account number is required.");
            if (value.Length != 22)
                throw new ArgumentException("Account number must be exactly 22 digits.");

            _accountNumber = value;
        }
    }

    private string _currency;
    public string Currency
    {
        get { return _currency; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Currency is required.");
            else if (value.Length != 3)
                throw new ArgumentException("Currency code must be exactly 3 letters (e.g. GEL, USD, EUR).");
            else if (!value.All(char.IsLetter))
                throw new ArgumentException("Currency must contain only letters."); // ეს ჯპტ ის ვკითხე

            _currency = value.ToUpper();
        }
    }

    private decimal _balance;
    public decimal Balance
    {
        get { return _balance; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Balance must be greater than 0");

            _balance = value;
        }
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be greater than 0.");

        _balance += amount;
        Console.WriteLine($"{amount} {Currency} deposited. New balance: {_balance} {Currency}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdraw amount must be greater than 0.");
        else if (amount > _balance)
            throw new InvalidOperationException("Insufficient funds.");
        _balance -= amount;
        Console.WriteLine($"{amount} {Currency} withdrawn. New balance: {_balance} {Currency}");
    }

    public void Transfer(Account target, decimal amount)
    {
        if (target == null)
            throw new ArgumentNullException(nameof(target));
        else if (amount <= 0)
            throw new ArgumentException("Transfer amount must be greater than 0.");
        else if (amount > _balance)
            throw new InvalidOperationException("Insufficient funds for transfer.");
        else if (this.Currency != target.Currency)
            throw new InvalidOperationException("Currency mismatch between accounts.");

        _balance -= amount;
        target._balance += amount;

        Console.WriteLine($"Transferred {amount} {Currency} from {AccountNumber} to {target.AccountNumber}");
    }
}

// დაწერეთ კლიენტის კლასი, რომელსაც ექნება
//     • სახელი
//     • გვარი
//     • პირადი ნომერი (11 ნიშნა)
//     • ანგარიში
public class Client
{
    private string _firstName;
    public string FirstName
    {
        get { return _firstName; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length < 50)
                _firstName = value;
            else
                throw new ArgumentException("First name must be between 1 and 50 characters.");
        }
    }

    private string _lastName;
    public string LastName
    {
        get { return _lastName; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length < 50)
                _lastName = value;
            else
                throw new ArgumentException("First name must be between 1 and 50 characters.");
        }
    }

    private string _personalNumber;
    public string PersonalNumber
    {
        get { return _personalNumber; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Personal number is required.");
            else if (value.Length != 11)
                throw new ArgumentException("Personal number must be exactly 11 digits.");
            else if (!value.All(char.IsDigit))
                throw new ArgumentException("Personal number must contain only digits.");

            _personalNumber = value;
        }
    }

    public Account Account { get; set; }

}
class Program
{
    static void Main()
    {
        Account acc1 = new Account
        {
            AccountNumber = "GE12345678901234567890",
            Currency = "GEL",
            Balance = 1000
        };

        Account acc2 = new Account
        {
            AccountNumber = "GE09876543210987654321",
            Currency = "GEL",
            Balance = 500
        };

        Client nika = new Client
        {
            FirstName = "Nika",
            LastName = "Ebralidze",
            PersonalNumber = "12345678901",
            Account = acc1
        };

        Client ana = new Client
        {
            FirstName = "Ana",
            LastName = "Beridze",
            PersonalNumber = "10987654321",
            Account = acc2
        };

        nika.Account.Deposit(100);

        nika.Account.Withdraw(200);

        nika.Account.Transfer(ana.Account, 300);

    }
}