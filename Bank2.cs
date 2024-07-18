using System;

public class BankAccount
{
    private string _accountNumber;
    private string _accountType;
    private double _balance;
    private string _accountHolderName;

    public BankAccount(string accountNumber, string accountType, double initialBalance, string accountHolderName)
    {
        _accountNumber = accountNumber;
        _accountType = accountType;
        _balance = initialBalance;
        _accountHolderName = accountHolderName;
    }

    public string AccountNumber
    {
        get { return _accountNumber; }
        set { _accountNumber = value; }
    }

    public string AccountType
    {
        get { return _accountType; }
        set { _accountType = value; }
    }

    public double Balance
    {
        get { return _balance; }
        set { _balance = value; }
    }

    public string AccountHolderName
    {
        get { return _accountHolderName; }
        set { _accountHolderName = value; }
    }

    public void AssignInitialAmount(double amount)
    {
        _balance = amount;
    }

    public void Deposit(double amount)
    {
        _balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: {_accountNumber}");
        Console.WriteLine("Account Type: {_accountType}");
        Console.WriteLine("Account Holder Name: {_accountHolderName}");
        Console.WriteLine("Balance: {_balance:C}");
    }
}

public class Bank2
{
    public static void Main()
    {
        Console.Write("Enter account number: ");
        string accountNumber = Console.ReadLine();

        Console.Write("Enter account type: ");
        string accountType = Console.ReadLine();

        Console.Write("Enter initial balance: ");
        double initialBalance = double.Parse(Console.ReadLine());

        Console.Write("Enter account holder name: ");
        string accountHolderName = Console.ReadLine();

        BankAccount account = new BankAccount(accountNumber, accountType, initialBalance, accountHolderName);

        Console.WriteLine("Initial Account Details:");
        account.DisplayAccountDetails();

        Console.Write("Enter amount to assign as initial amount: ");
        double initialAmount = double.Parse(Console.ReadLine());
        account.AssignInitialAmount(initialAmount);
        Console.WriteLine("New Balance: {account.Balance:C}");

        Console.Write("Enter amount to deposit: ");
        double depositAmount = double.Parse(Console.ReadLine());
        account.Deposit(depositAmount);
        Console.WriteLine("New Balance: {account.Balance:C}");

        Console.Write("Enter amount to withdraw: ");
        double withdrawAmount = double.Parse(Console.ReadLine());
        account.Withdraw(withdrawAmount);
        Console.WriteLine("New Balance: {account.Balance:C}");

        Console.WriteLine("Final Account Details:");
        account.DisplayAccountDetails();
    }
}