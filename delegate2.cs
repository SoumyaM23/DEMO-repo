using System;

public class Test{
	 public delegate void del_call(int a,int b);
	
	 public void addnum(int a,int b)
	 {
		 Console.WriteLine("Sum={0}:",a+b);
	 }
	
	 public void subnum(int a,int b)
	 {
		 Console.WriteLine("Diff={0}:",a-b);
	 }
	
	public static void Main(String[] args)
	{
	
	 	Test t = new Test();
		del_call d = new del_call(t.addnum);// multicasting
		d+= t.subnum;
		d(6,9);
	}	
}