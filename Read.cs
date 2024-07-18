class Read
{
	public static void Main(string[] args)
	{
		double a=System.Convert.ToDouble(args[0]);	
		double b=System.Convert.ToDouble(args[1]);

		System.Console.WriteLine("{0}", a>b);
	}
}