using System;

public class MyException : Exception{
	
	public MyException(string msg) : base(msg)
	{
	}
}

public class test{
	public static void Main(String[] args){
		int a =10, b= 60;
		try{
			if(b>a)
				throw(new MyException("b can't be greater than a!!!"));
			else
				Console.WriteLine("Diff:{0}",a-b);
		}
		
		catch(MyException e){
			Console.WriteLine("Exception caught is: {0}",e.Message);
		}
	}
}
			