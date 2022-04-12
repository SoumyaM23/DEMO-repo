using System;

public class ParamArray{
	public int sum = 0;
	
	public int AddArray(params int[] ar)
	{
		for(int i=0;i<ar.Length;i++)
			sum = sum+ar[i];
		
		return sum;
	}
}

public class Test{
	public static void Main(String[] args)
	{
	 ParamArray P1 = new ParamArray();
	 int s1 = P1.AddArray(12,56,34,24);	
	 Console.WriteLine("Sum={0}",s1);
		
	 ParamArray P2 = new ParamArray();
     int s2 = P2.AddArray(57,24);	
	 Console.WriteLine("Sum={0}",s2);	 
	}	
}