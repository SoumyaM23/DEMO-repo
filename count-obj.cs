using System;
public class Program 
{
   public static int count;
   
  public  Program()
   {
       count++;
   }
   
  public  Program(int a)
   {
       count++;
   }
   
}

public class Calling
{
    static void Main(string[] args)
    {
    Program p;
    
    Program P1 = new Program();
    Program P2 = new Program(3);
    
    Console.WriteLine("count = {0}",Program.count);
}
}