using System;

public class DivisionNumbers{
int res;

public DivisionNumbers()
{
	res = 0;
}

public void division(int a,int b)
{
	try{
	res = a/b;
	}
	catch(DivideByZeroException e)
	{
		Console.WriteLine("Exception:{0}",e);
	}
    finally{
		Console.WriteLine("Result:{0}",res);
	}
}	
	

	public static void Main(string[]args)
	{
     
	DivisionNumbers d =new DivisionNumbers();
	d.division(9,3);
	d.division(6,0);	
	}
}