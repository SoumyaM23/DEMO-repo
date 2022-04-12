using System;

public class Program
    {
        public static string NameShuffle(string str)
        {
					string s = null;
					int j=str.IndexOf(" ");
					for(int i=j+1; i<str.Length;i++)
					{
						s =s+str[i];
					}
					s=s+" ";
					
						for(int i=0; i<j;i++)
					{
						s =s+str[i];
					}
            return s;
        }
    
         static void Main(string[] args)
        {
            //Program P = new Program();
           string s = NameShuffle("Som Mish");
           Console.WriteLine(s);
        }
    }