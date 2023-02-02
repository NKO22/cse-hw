using System;

public class Entry
{
  public string _userInput;
  public DateTime _date = DateTime.Now;
  public string _question;
  public void DisplayEntry()
  {
    if (String.IsNullOrEmpty(_userInput))
    {
      
      Console.WriteLine("Entry first or load my daily journal.");
      

    }
    else
    {

      
      Console.WriteLine($"{_date} - {_question}");
      Console.WriteLine($"{_userInput}");
      
    }

  }
}
