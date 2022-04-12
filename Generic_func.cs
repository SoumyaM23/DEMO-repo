using System;

public class Test{
	public static void GenericSwap<T>(ref T x, ref T y){
	T temp;
	temp =x;
	x=y;
	y=temp;
	
	}
	
	public static void Main(String[] args){
		Console.WriteLine("Enter Integer values of a and b:");
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Values before swapping a={0} and b={1}",a,b);
		
		GenericSwap<int>(ref a, ref b);
		
		Console.WriteLine("Values after swapping a={0} and b={1}",a,b);
		
		Console.WriteLine("Enter String values of x and y:");
		String x = Console.ReadLine();
		String y = Console.ReadLine();
		
		Console.WriteLine("Values before swapping x={0} and y={1}",x,y);
		
		GenericSwap<String>(ref x, ref y);
		
		Console.WriteLine("Values after swapping a={0} and b={1}",x,y);
}
}