class ContinueBreak1
{
	public void ContinueBreakMethod()
	{
		int n=10;
		while(n<200)
		{
			if(n<50)
			{
				System.Console.Write(" "+n);
				n=n+10;
				continue;
			}
			if(n==50)
			{
				System.Console.WriteLine();
				n=n+10;
				continue;
			}
			if(n>90)break;
			System.Console.Write(" "+ n);
			n=n+10;
		}
		System.Console.WriteLine();
	}
}
class ContinueBreak
{
	public static void Main(string[] args)
	{
		ContinueBreak1 obj=new ContinueBreak1();
		obj.ContinueBreakMethod();
	}
}