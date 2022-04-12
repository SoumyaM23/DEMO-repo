using System;

public class Test{
	public static void Main(String[] args)
	{
	  Console.WriteLine("Enter a string:");
	  string s = Console.ReadLine();	
	  for(int i=0;i<s.Length;i++)
		  if(Char.IsDigit(s[i]))
			  Console.WriteLine("Digit");
		  else if(Char.IsLetter(s[i]))
			   Console.WriteLine("Letter");
		  else if(Char.IsWhiteSpace(s[i]))
			    Console.WriteLine("WhiteSpace");
		  else
			    Console.WriteLine("Special Symbol");
	}
}