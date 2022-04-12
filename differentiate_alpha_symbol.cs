using System;
					
public class Program
{
	 public  static void Main(string[] args)
    {
     Console.WriteLine("Enter a character");
	 char letter = Convert.ToChar(Console.ReadLine());
	 if(letter>='a' && letter<='z')
		 Console.WriteLine("Small letter");
	else if(letter>='A' && letter<='Z')
		 Console.WriteLine("Capital letter");
	else if(letter>='0' && letter<='9')
		 Console.WriteLine("Digit");
	else
		 Console.WriteLine("Special symbol");
}
}