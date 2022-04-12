public class Program
{
    public static string HackerSpeak(string str)
    {
			for(int i=0;i<str.Length;i++)
			{
			if(str[i].Equals('a'))
			 str =	str.Replace('a','4');
				
			else if(str[i].Equals('e'))
				str = str.Replace('e','3');
				
			else if(str[i].Equals('i'))
				str =str.Replace('i','1');
				
			else if(str[i].Equals('o'))
				str = str.Replace('o','0');
				
			else if(str[i].Equals('s'))
				str = str.Replace('s','5');
    }
			return str;
}
}