class Auth
{
	
	enum AccountType
	{
		Saving = 1,
		Current,
	}
	
	private static int accountNo, New = 0;
	private static int[] existingAccountNo = new int[10];
	private static string[] name = new string[10];
	private static long[] phoneNo = new long[10];
	private static int[] accountType = new int[10];
	
	public static void Login()
	{
		System.Console.Clear();
		System.Console.Write("Enter Account Number: ");
		accountNo = System.Convert.ToInt32(System.Console.ReadLine());
		
		if(Verification(accountNo))
		{
			System.Console.WriteLine("Welcome");
			Transaction.Display();
		}
		else
		{
			System.Console.WriteLine("\nError: Account does not exist");
			System.Console.WriteLine("1. Retry");
			System.Console.WriteLine("2. Create New Account");
			System.Console.Write("Enter your choice: ");
			switch(System.Console.ReadLine())
			{
				case "1":
					Auth.Login();
					break;
				case "2":
					Auth.CreateNewAccount();
					break;
				default:
					System.Console.WriteLine("Invalid Choice");
					break;
			}
		}
	}

	private static bool Verification(int accountNo)
	{
		foreach(int i in existingAccountNo)
		{
			if(accountNo == i)
				return true;
		}
		return false;
	}

	private static void CreateNewAccount()
	{
		System.Console.Clear();
		New++;
		System.Console.Write("Enter Your Name: ");
		name[New] = System.Console.ReadLine();
		System.Console.Write("Enter Phone Number: ");
		phoneNo[New] = System.Int64.Parse(System.Console.ReadLine());
		System.Console.WriteLine("Select Account Type: ");
		System.Console.WriteLine("\t1. Saving Account");
		System.Console.WriteLine("\t2. Current Account");
		System.Console.Write("Enter here: ");
		accountType[New] = System.Int32.Parse(System.Console.ReadLine());
		
		/***************************** Checking ****************************/

		System.Console.WriteLine();
		System.Console.WriteLine("Your Name: " + name[New]);
		System.Console.WriteLine("Phone Number: " + phoneNo[New]);
		System.Console.WriteLine("Account Type: " + (AccountType)accountType[New]);
		
		System.Console.WriteLine("\nIs above information correct: ");
		System.Console.WriteLine("1. Yes");
		System.Console.WriteLine("2. No");

		switch(System.Console.ReadLine())
		{
			case "1":
				System.Console.Clear();
				existingAccountNo[New] = System.Convert.ToInt32("101" + (New+1).ToString());
				System.Console.WriteLine("Your Account Number is : 101" + (New+1) );
				System.Console.Write("Click Enter to continue......... ");
				System.Console.ReadLine();
				Auth.Login();
				break;
			case "2":
				New--;
				Auth.CreateNewAccount();
				break;
			default:
				System.Console.WriteLine("Invalid Choice");
				break;
		}
		
	}
}

class Transaction
{
	private static int deposit,withdraw,balance = 1000;
	private static string a;
	public static void Display()
	{

		do
		{
			System.Console.WriteLine("1. Deposit Amount");
			System.Console.WriteLine("2. Withdraw Amount");
			System.Console.WriteLine("3. Check Balance");
			System.Console.WriteLine("4. Exit");
			System.Console.Write("Enter your choice: ");
			a = System.Console.ReadLine();
			switch(a)
			{
				case "1":
					System.Console.Write("Enter the deposit amount: ");
					deposit = System.Convert.ToInt32(System.Console.ReadLine());
					if(deposit > 500)
					{
						balance += deposit;
						System.Console.WriteLine("Amount deposit successfully");
					}
					else
					{
						System.Console.WriteLine("Minimum deposit amonut is 500");
					}
					break;
				case "2":
					System.Console.Write("Enter the withdraw amount: ");
					withdraw = System.Convert.ToInt32(System.Console.ReadLine());
					if(withdraw < balance)
					{
						if(withdraw>=100)
						{	
							balance -= withdraw;
							System.Console.WriteLine("Amount withdraw successfully");
							System.Console.WriteLine("Balance amount is : " + balance);
						}
						else
						{
							System.Console.WriteLine("Minimum withdraw amonut is 100");
						}
					}
					else
					{
						System.Console.WriteLine("Insufficient bank balance");
					}

					break;
				case "3":
					System.Console.WriteLine("Balance amount is : " + balance);
					break;
				case "4":
    					System.Console.WriteLine("Exiting...");
					break;
				default:
					System.Console.WriteLine("Invalid Choice");
					break;
			}
		}
		while(a != "4");
	}
}

class Bank
{
	public static void Main(string[] args)
	{
		Auth.Login();
	}
}