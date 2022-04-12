using System;

public class Test{
	 public delegate void sum(int a,int b);
	 public void addnum(int a,int b)
	 {
		 Console.WriteLine("Sum={0}:",a+b);
	 }
	public static void Main(String[] args)
	{
	
	 	Test t = new Test();
		sum s = new sum(t.addnum);
		s(6,9);
	}	
}