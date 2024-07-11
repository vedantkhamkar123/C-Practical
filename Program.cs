using System;
class Program
{
	public static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of clothes (milk/handloom): ");
            string clothType = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the purchase amount: ");
            double purchaseAmount = Convert.ToDouble(Console.ReadLine());

            double discount = 0;

            switch (clothType)
            {
                case "milk":
                    if (purchaseAmount >= 0 && purchaseAmount <= 100)
                    {
                        discount = 0;
                    }
                    else if (purchaseAmount >= 101 && purchaseAmount <= 200)
                    {
                        discount = 5;
                    }
                    else if (purchaseAmount >= 201 && purchaseAmount <= 300)
                    {
                        discount = 7.5;
                    }
                    else if (purchaseAmount > 300)
                    {
                        discount = 10;
                    }
                    break;

                case "handloom":
                    if (purchaseAmount >= 0 && purchaseAmount <= 100)
                    {
                        discount = 5;
                    }
                    else if (purchaseAmount >= 101 && purchaseAmount <= 200)
                    {
                        discount = 7.5;
                    }
                    else if (purchaseAmount >= 201 && purchaseAmount <= 300)
                    {
                        discount = 10;
                    }
                    else if (purchaseAmount > 300)
                    {
                        discount = 15;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid cloth type.");
                    return;
            }

            double discountAmount = (purchaseAmount * discount) / 100;
            double finalAmount = purchaseAmount - discountAmount;

            Console.WriteLine("Original Amount: "+purchaseAmount);
            Console.WriteLine("Discount: " +discount+ "%");
            Console.WriteLine("Discount Amount: "+discountAmount);
            Console.WriteLine("Final Amount to Pay: "+finalAmount);
        
    }
}
