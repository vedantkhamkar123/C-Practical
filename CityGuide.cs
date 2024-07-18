class CityGuide
{
	public static void Main(string[] args)
	{
		System.Console.WriteLine("Select your choice");
		System.Console.WriteLine("London");
		System.Console.WriteLine("Bombay");
		System.Console.WriteLine("Paris");
		System.Console.WriteLine("Type your choice");

		string name=  System.Console.ReadLine();

		switch(name)
		{
			case "Bombay":
				System.Console.WriteLine("Bombay:Guide 5");
				break;

			case "London":
				System.Console.WriteLine("London:Guide 10");
				break;

			case "Paris":
				System.Console.WriteLine("London:Guide 15");
				break;

			default:
				System.Console.WriteLine("Invalid Choice");
				break;
		}
	}
}