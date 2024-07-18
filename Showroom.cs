class Showroom
{
	public static void Main(string[] args)
	{
		int i,Purchase_amount;
		double Milk;
		double Handloom;
		
		System.Console.WriteLine("Select the cloth of purchase");
		string cloth=System.Console.ReadLine();
		System.Console.WriteLine("Milk cloth");
		System.Console.WriteLine("Handloom cloth");		
		Purchase_amount=System.Convert.ToInt32(cloth);
		switch(cloth)
		{
			case 1:     
				{
					if(Purchase_amount <= 100)
					{
						System.Console.WriteLine("No Discount");
					}
					else 
					{
						Handloom=Purchase_amount-(5.0/100*100);
						System.Console.WriteLine("Discount is "+Handloom);
					}
				}
			case 2:
				{
					if(101 <=200)
					{
						Milk=Purchase_amount-(5/200*100);
					        System.Console.WriteLine("Discount is "+Milk);
					}
					else
					{
						Handloom=Purchase_amount-(7.5/200*100);
						
		}
	}

}