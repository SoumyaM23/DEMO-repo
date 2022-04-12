using System;
					
public class Program
{
	 public  static void Main(string[] args)
    {
      int i=0,c=1;
	  string s=null;
	 Console.WriteLine("Enter a string");	 
	 s=Console.ReadLine();
	 for(i=0;i<s.Length;i++)
	 {
		if( Char.IsWhiteSpace(s[i]))
			c++;
	 }	
	 Console.WriteLine(c);
	 	 
}
}