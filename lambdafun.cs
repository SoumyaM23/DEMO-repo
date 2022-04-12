using System;

public class Test{
	public static void Main(String[] args)
	{
	 Func<int,int> square = x=>x*x;
	 int y = square(7);	
	 Console.WriteLine(	y);
		
	 Func<int,int,bool> compare = (a,b) => a>b;
	 bool val = compare(2,9);	
	 Console.WriteLine(val);	
		
	Func<string,string,bool> str_cmp =(s1,s2) =>{if(s1.Equals(s2)) return true; else return false;};	
	bool res = str_cmp("abcd","abcd");
	Console.WriteLine(res);	
	}	
}