using System;

public abstract class A
{
	public abstract void show();
}

public class B : A
{
 public override void show()
 {
	 Console.WriteLine("Overriding show");
 }
}

public class Test{
	public static void Main(String[] args)
	{
	 B b = new B();
	 b.show();
	 	
	}
}