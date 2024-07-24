class BankAccount
{
    private string name;
    private double balance;

    public BankAccount(string name, double initialDeposit)
    {
        this.name = name;
        this.balance = initialDeposit;
    }

    public string GetName()
    {
        return name;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            System.Console.WriteLine("Successfully deposited " + amount + ". New balance: " + balance);
        }
        else
        {
            System.Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public bool Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            System.Console.WriteLine("Successfully withdrew " + amount + ". New balance: " + balance);
            return true;
        }
        else if (amount > balance)
        {
            System.Console.WriteLine("Insufficient funds.");
            return false;
        }
        else
        {
            System.Console.WriteLine("Withdrawal amount must be positive.");
            return false;
        }
    }

    public void DisplayBalance()
    {
        System.Console.WriteLine("Account holder: " + name + ", Balance: " + balance);
    }
}

class Vk
{
    static void Main(string[] args)
    {
        System.Collections.ArrayList accounts = new System.Collections.ArrayList();
        bool running = true;

        while (running)
        {
            System.Console.WriteLine("\n--- Bank System Menu ---");
            System.Console.WriteLine("1. Create a new account");
            System.Console.WriteLine("2. Check balance");
            System.Console.WriteLine("3. Deposit money");
            System.Console.WriteLine("4. Withdraw money");
            System.Console.WriteLine("5. Exit");
            System.Console.Write("Choose an option: ");

            string choice = System.Console.ReadLine();

            switch (choice)
            {
                case "1":
                    System.Console.Write("Enter account holder's name: ");
                    string name = System.Console.ReadLine();
                    System.Console.Write("Enter initial deposit amount: ");
                    double initialDeposit = System.Convert.ToDouble(System.Console.ReadLine());
                    accounts.Add(new BankAccount(name, initialDeposit));
                    System.Console.WriteLine("Account created successfully.");
                    break;

                case "2":
                    System.Console.Write("Enter account holder's name: ");
                    string checkName = System.Console.ReadLine();
                    BankAccount accountToCheck = null;
                    foreach (BankAccount account in accounts)
                    {
                        if (account.GetName().Equals(checkName, System.StringComparison.OrdinalIgnoreCase))
                        {
                            accountToCheck = account;
                            break;
                        }
                    }
                    if (accountToCheck != null)
                    {
                        accountToCheck.DisplayBalance();
                    }
                    else
                    {
                        System.Console.WriteLine("Account not found.");
                    }
                    break;

                case "3":
                    System.Console.Write("Enter account holder's name: ");
                    string depositName = System.Console.ReadLine();
                    BankAccount accountToDeposit = null;
                    foreach (BankAccount account in accounts)
                    {
                        if (account.GetName().Equals(depositName, System.StringComparison.OrdinalIgnoreCase))
                        {
                            accountToDeposit = account;
                            break;
                        }
                    }
                    if (accountToDeposit != null)
                    {
                        System.Console.Write("Enter deposit amount: ");
                        double depositAmount = System.Convert.ToDouble(System.Console.ReadLine());
                        accountToDeposit.Deposit(depositAmount);
                    }
                    else
                    {
                        System.Console.WriteLine("Account not found.");
                    }
                    break;

                case "4":
                    System.Console.Write("Enter account holder's name: ");
                    string withdrawName = System.Console.ReadLine();
                    BankAccount accountToWithdraw = null;
                    foreach (BankAccount account in accounts)
                    {
                        if (account.GetName().Equals(withdrawName, System.StringComparison.OrdinalIgnoreCase))
                        {
                            accountToWithdraw = account;
                            break;
                        }
                    }
                    if (accountToWithdraw != null)
                    {
                        System.Console.Write("Enter withdrawal amount: ");
                        double withdrawAmount = System.Convert.ToDouble(System.Console.ReadLine());
                        accountToWithdraw.Withdraw(withdrawAmount);
                    }
                    else
                    {
                        System.Console.WriteLine("Account not found.");
                    }
                    break;

                case "5":
                    running = false;
                    System.Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    System.Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
