using System;

class Prac1d
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Choose an operation");
		Console.WriteLine("1. Generate Fibonacci Series");
		Console.WriteLine("2. Test for Prime Numbers");
		Console.WriteLine("3. Test for vowels");
		Console.WriteLine("4. Reverse a number and find sum of digits");
		Console.WriteLine("Enter your choice(1-4):");
		int choice = int.Parse(Console.ReadLine());
		
		switch(choice)
		{
			case 1:
				GenerateFibonacciSeries();
				break;

			case 2:
				TestForPrimeNumbers();
				break;

			case 3:
				TestForVowels();
				break;

			case 4:
				ReverseNumberAndSumDigits();
				break;

			default:
				Console.WriteLine("Invalid Choice!!!");
				break;
		}
	}

	static void GenerateFibonacciSeries()
	{
		Console.Write("Enter a number:");
		int n=int.Parse(Console.ReadLine());
		int a=0,b=1,c;
		Console.Write("Fibonacci Series:"+a+" "+b+" ");
		for(int i=2;i<n;i++)
		{
			c=a+b;
			Console.Write(c+" ");
			a=b;
			b=c;
		}
		Console.WriteLine();
	}
	
	static void TestForPrimeNumbers()
	{
		Console.Write("Enter a number:");
		int num=int.Parse(Console.ReadLine());
		bool isPrime=true;

		if(num<=1)
		{
			isPrime=false;
		}
		else
		{
			for(int i=2;i<=Math.Sqrt(num);i++)
			{
				if(num%i==0)
				{
					isPrime=false;
					break;
				}
			}
		}
		if(isPrime)
		{
			Console.WriteLine(num+"is a prime number");
		}
		else
		{
			Console.WriteLine(num+"is not a prime number");
		}
	}
	
	static void TestForVowels()
	{
		Console.Write("Enter a Charachter:");
		char ch=char.Parse(Console.ReadLine().ToLower());
		if("aeiou".IndexOf(ch)>=0)
		{
			Console.WriteLine(ch+"is a vowel");
		}
		else
		{
			Console.WriteLine(ch+"is not a vowel");
		}
	}
	
	static void ReverseNumberAndSumDigits()
	{
		Console.WriteLine("Enter a number:");
		int num=int.Parse(Console.ReadLine());
		int reversedNum=0,sumOfDigits=0;

		while(num!=0)
		{
			int digit=num%10;
			reversedNum=reversedNum*10+digit;
			sumOfDigits +=digit;
			num/=10;
		}
	
	Console.WriteLine("Reversed number:"+reversedNum);
	Console.WriteLine("Sum of Digits:"+sumOfDigits);
	}
}