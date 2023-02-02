using System;

class Program
{
  static void Main(string[] args)
  {
    bool flag = true;
    int menuNum;
    Journal journal = new Journal();
    Console.WriteLine("Welcome to my personal Journal!");

    do
    {
      Console.WriteLine("What do you want to do today?");
      Console.WriteLine("1 - Write");
      Console.WriteLine("2 - Display");
      Console.WriteLine("0 - Quit");
      Console.Write("choose a  number: ");
      menuNum = int.Parse(Console.ReadLine());

      if (menuNum == 1)
      {
        journal.WriteEntry();
      }
      else if (menuNum == 2)
      {
        journal.ReadEntry();
      }
      else 
      {
        Console.WriteLine("Good bye!! The future will tell us more");
        flag = false;
      }

    } while (flag == true);


  }
}
