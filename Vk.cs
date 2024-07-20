using System;
using System.Collections.Generic;

class BankAccount
{
    public string Name { get; private set; }
    public double Balance { get; private set; }

    public BankAccount(string name, double initialDeposit)
    {
        Name = name;
        Balance = initialDeposit;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine("Successfully deposited " + amount + ". New balance: " + Balance);
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public bool Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine("Successfully withdrew " + amount + ". New balance: " + Balance);
            return true;
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
            return false;
        }
        else
        {
            Console.WriteLine("Withdrawal amount must be positive.");
            return false;
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine("Account holder: " + Name + ", Balance: " + Balance);
    }
}

class Vk
{
    static void Main(string[] args)
    {
        List<BankAccount> accounts = new List<BankAccount>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Bank System Menu ---");
            Console.WriteLine("1. Create a new account");
            Console.WriteLine("2. Check balance");
            Console.WriteLine("3. Deposit money");
            Console.WriteLine("4. Withdraw money");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter account holder's name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter initial deposit amount: ");
                    double initialDeposit = Convert.ToDouble(Console.ReadLine());
                    accounts.Add(new BankAccount(name, initialDeposit));
                    Console.WriteLine("Account created successfully.");
                    break;

                case "2":
                    Console.Write("Enter account holder's name: ");
                    string checkName = Console.ReadLine();
                    BankAccount accountToCheck = accounts.Find(a => a.Name.Equals(checkName, StringComparison.OrdinalIgnoreCase));
                    if (accountToCheck != null)
                    {
                        accountToCheck.DisplayBalance();
                    }
                    else
                    {
                        Console.WriteLine("Account not found.");
                    }
                    break;

                case "3":
                    Console.Write("Enter account holder's name: ");
                    string depositName = Console.ReadLine();
                    BankAccount accountToDeposit = accounts.Find(a => a.Name.Equals(depositName, StringComparison.OrdinalIgnoreCase));
                    if (accountToDeposit != null)
                    {
                        Console.Write("Enter deposit amount: ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        accountToDeposit.Deposit(depositAmount);
                    }
                    else
                    {
                        Console.WriteLine("Account not found.");
                    }
                    break;

                case "4":
                    Console.Write("Enter account holder's name: ");
                    string withdrawName = Console.ReadLine();
                    BankAccount accountToWithdraw = accounts.Find(a => a.Name.Equals(withdrawName, StringComparison.OrdinalIgnoreCase));
                    if (accountToWithdraw != null)
                    {
                        Console.Write("Enter withdrawal amount: ");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        accountToWithdraw.Withdraw(withdrawAmount);
                    }
                    else
                    {
                        Console.WriteLine("Account not found.");
                    }
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}