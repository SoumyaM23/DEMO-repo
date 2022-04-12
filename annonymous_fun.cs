using System;

public class Test{
	 public delegate int del_call(int a,int b);
	
	 public static void Main(String[] args)
	{
	
	 	Test t = new Test();
		del_call d = delegate(int a, int b){ // annonymous function
			return a+b;
		};
		int res = d(20,16);
		Console.WriteLine("Result:{0}",res); 
		 
	}	
}