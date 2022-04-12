using System;
					
public class Program
{
	 public  static void Main(string[] args)
    {
     string s = "ABCvtw";
      Console.WriteLine(s);
      s= s.ToUpper();
      Console.WriteLine(s);
	  s= s.ToLower();
      Console.WriteLine(s);	 
		s="QweTYRo";
		 
	for(int i=0;i<s.Length;i++)
	{
	 if(s[i]>='a' && s[i]<='z')
	 {
		s= s.Replace(s[i],(char)(s[i]-32));
	 }
		else
			s = s.Replace(s[i],(char)(s[i]+32));
	}
		  Console.WriteLine(s);
		
    }
	}