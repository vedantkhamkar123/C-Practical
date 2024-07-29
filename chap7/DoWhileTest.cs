class DoWhileTest1
{
	public void DoWhileTestMethod()
	{
		int row,column,y;
		row=1;
		System.Console.WriteLine("Multiplication Table \n");
		
		do
		{
			column =1;
			
			do
			{
				y=row*column;
				System.Console.Write(" "+ y);
				column =column +1;
			}
			while(column<=3);
			System.Console.WriteLine("\n");
			row=row+1;
		}
		while(row<= 3);
	}
}
class DoWhileTest
{
	public static void Main(string[] args)
	{
		DoWhileTest1 obj = new DoWhileTest1();
		obj.DoWhileTestMethod();
	}
}