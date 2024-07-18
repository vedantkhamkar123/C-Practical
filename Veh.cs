class Veh
{
	public static void Main(string[] args)
	{
		
		double u=System.Convert.ToDouble(args[0]);	
		double a=System.Convert.ToDouble(args[1]);
		double t=System.Convert.ToDouble(args[2]);

		double d=(u*t+(1/2)*(a*t*t));
	
		System.Console.WriteLine("{0}",d);
	}
}