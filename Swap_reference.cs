using System;

public class Test{
	static void swap_val(int a, int b){
		int temp;
		
		temp =a;
		a= b;
		b= temp;
	}
	
	static void swap_ref(ref int a, ref int b){
	 int temp;
	 
		temp =a;
		a= b;
		b= temp;
		
	}
	
	public static void Main(String[] args)
	{
		int a =16 , b =81;
		
		Console.WriteLine("Implementing SWAP BY VALUE..............");
		Console.WriteLine("Values before swapping: a = {0} , b = {1}", a,b);
		swap_val(a,b);
		Console.WriteLine("Values after swapping: a = {0} , b = {1}", a,b);
		
		Console.WriteLine("Implementing SWAP BY REFERENCE..............");
		Console.WriteLine("Values before swapping: a = {0} , b = {1}", a,b);
		swap_ref(ref a,ref b);
		Console.WriteLine("Values after swapping: a = {0} , b = {1}", a,b);
		
	}
}