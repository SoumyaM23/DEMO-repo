using System;
					
public class Program
{
	 public  static void Main(string[] args)
    {
     string s = "ABCvtw";
	 string st = null;
     for(int i =s.Length-1;i>=0;i--)
	 {
		 st = st+s[i];
    
	 }
		 Console.WriteLine(st);
}
}