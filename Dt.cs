class Dt
{
	public static void Main(string[] args)
	{
		int a=101;
        object obj1=(object)a;
		System.Console.WriteLine(obj1);

		int b=102;
		object obj2=b;
		
		int c=(int)obj2;
		
		System.Console.WriteLine(obj2);

		System.Console.WriteLine(c);

	}
}