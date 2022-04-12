using System;
					
public class Program
{
	 public  static void Main(string[] args)
    {
      int i=0,j=0;
	  string s ="HelloAll", t ="World!", n=null;
		 while(i<s.Length || j<t.Length)
		 {
			 if(i>=s.Length)
				n=n+t[j]; 
			 else if(j>=t.Length)
				 n=n+s[i];
			 else
			    n = n+s[i]+t[i];
			 
			 i++;
			 j++;
		 }
		 Console.WriteLine(n);
		 
}
}