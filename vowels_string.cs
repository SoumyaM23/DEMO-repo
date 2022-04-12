public class Program 
{
    public static int CountVowels(string str) 
    {
			int count=0;
			
			for(int i=0;i<str.Length;i++){
      if(str[i].Equals('A') || str[i].Equals('E') || str[i].Equals('I') || str[i].Equals('O') || str[i].Equals('U')||str[i].Equals('a')||str[i].Equals('e')||str[i].Equals('i')||str[i].Equals('o')||str[i].Equals('u'))
			 count++;
			}
			return count;
    }
}