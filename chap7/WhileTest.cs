class WhileTest1
{
	public void WhileTestMethod()
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
				System.Console.Write(" "+n);
				n++;
			}
		}
	}
}
class WhileTest
{
	public static void Main(string[] args)
	{
		WhileTest1 obj1=new WhileTest1();
		obj1.WhileTestMethod();
	}
}
		
		