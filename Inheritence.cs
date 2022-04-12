using System;

public class Shape
{
	public int l;
	public int b;
	
	public Shape(int l, int b)
	{
		this.l = l;
		this.b = b;
	}
	 
   public virtual void area()
   {
	   Console.WriteLine("area");
   }
}

public class Rect : Shape
{
 public Rect(int l, int b): base(l,b){}
 
 public override void area()
 {
  Console.WriteLine("Area:{0}",l*b);
  }
  }
  
public class Test{
	public static void Main(String[] args)
	{
		Rect r = new Rect(16,12);
		r.area();
	}
}