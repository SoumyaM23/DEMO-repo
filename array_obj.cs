using System;
public class Program 
{
   public static int count;
   public int a;
   
  public  Program()
   {
       count++;
   }
   
  public  Program(int a)
   {
       this.a =a;
       count++;
   }
   
   public void show()
   {
       Console.WriteLine("A ={0}",a);
   }
}


public class Calling
{
    static void Main(string[] args)
    {
    //Program *p;
    Program[] P1 = new Program[2];
    P1[0] = new Program();
    P1[0].show();
    P1[1] = new Program(20);
    P1[1].show();
    
    Console.WriteLine("count = {0}",Program.count);
}
}