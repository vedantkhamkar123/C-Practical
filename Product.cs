class Product
{
	public static void Main(string[] args)
	{
	   int Product;
	   int a= System.Convert.ToInt32(args[0]);
	   int b= System.Convert.ToInt32(args[1]);
     	   int c= System.Convert.ToInt32(args[2]);
	   int d= System.Convert.ToInt32(args[3]);

	   Product = a * b * c * d;
	   System.Console.WriteLine("The product of the four values: " + Product);
	}

}