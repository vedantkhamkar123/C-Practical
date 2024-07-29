class ForeachTest1
{
	public void ForeachTestMethod()
	{
		int[] arrayInt = { 11,22,33,44}
		foreach( int m in arrayInt)
		{
			System.Console.Write(" " +m);
		}
		System.Console.WriteLine();
	}
}
class ForeachTest
{
	public static void Main(string[] args)
	{
		ForeachTest1 obj=new ForeachTest1();
		obj.ForeachTestMethod();
	}
}