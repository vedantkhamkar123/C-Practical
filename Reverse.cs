using System;

public class NumberReverser
{
    public int ReverseNumber(int number)
    {
        int reversedNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }

        return reversedNumber;
    }
}

public class Reverse
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        NumberReverser reverser = new NumberReverser();
        int reversedNumber = reverser.ReverseNumber(number);

        Console.WriteLine("The reversed number is: " + reversedNumber);
    }
}