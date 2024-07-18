class WhileTest
{
	public static void Main(string[] args)
	{
		int n=1;
		while (n<=10)
		{
			if(n%2==0)
			{
				n++;
			}
			else
			{
				System.Console.WriteLine(" "+n);
				n++;
			}
		}
	}
}