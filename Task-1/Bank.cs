// საშუალო დავალება: “ბანკის ანგარიში და ტრანზაქციები”
// ამოცანა:

// შექმენი სისტემა, რომელიც მართავს ბანკის ანგარიშებს, სხვადასხვა ტიპის ანგარიშებით (მიმდინარე და სესხის),
// და საშუალებას იძლევა ტრანზაქციების შესრულება — ყველაფერი ობიექტზე ორიენტირებულად.
// მოთხოვნები:

// 1. შექმენი აბსტრაქტული კლასი BankAccount:

public abstract class BankAccount
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; protected set; }

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative.");

        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public abstract void Withdraw(decimal amount);

    public virtual void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");
        Balance += amount;
    }
}

// შექმენი ორი შვილობილი კლასი:
//     o CheckingAccount — ჩვეულებრივი ანგარიში, რომელსაც შეუძლია გატანა თუ საკმარისი თანხაა.
public class CheckingAccount : BankAccount
{
    public CheckingAccount(string accountNumber, decimal initialBalance) : base(accountNumber, initialBalance) { }
    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");
        if (amount > Balance)
            throw new ArgumentException("There are not enough funds in the account.");

        Balance -= amount;
    }

    public override void Deposit(decimal amount)
    {
        base.Deposit(amount);
    }
}
//     o LoanAccount — ანგარიშიდან თანხის გატანა მიუწვდომელია, მხოლოდ გადახდა (Deposit) შესაძლებელია.
public class LoanAccount : BankAccount
{
    public LoanAccount(string accountNumber, decimal initialBalance) : base(accountNumber, initialBalance) { }
    public override void Withdraw(decimal amount)
    {
        throw new ArgumentException("Unable to withdraw funds");
    }

    public override void Deposit(decimal amount)
    {
        base.Deposit(amount);
    }
}

// 25. დაამატე პოლიმორფიზმი:
//     o ორივე კლასში override გააკეთე საჭირო მეთოდებზე (Withdraw ან Deposit).

// 26. შექმენი კლასი TransactionService:
//     o მეთოდი public void Transfer(BankAccount from, BankAccount to, decimal amount) რომელიც აკლებს თანხას ერთი ანგარიშიდან და ამატებს მეორეში.
//     o დაამატე Exception Handling ისეთი შემთხვევისთვის, როცა თანხა არასაკმარისია.
public class TransactionService
{
    public void Transfer(BankAccount from, BankAccount to, decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Transfer amount must be positive.");

        try
        {
            if (from.Balance < amount)
                throw new ArgumentException("Insufficient amount");

            from.Withdraw(amount);
            to.Deposit(amount);
            Console.WriteLine("Complete Amount");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Transfer failed: {ex.Message}");
        }
    }
}

// 27. Main მეთოდში:

//     o შექმენი რამდენიმე ანგარიში (CheckingAccount, LoanAccount).
//     o სცადე ტრანსფერი სხვადასხვა ანგარიშებს შორის.
//     o გამოიყენე try-catch-finally და გამოიტანე შესაბამისი შეტყობინებები.
