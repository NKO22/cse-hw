using System;
using System.Collections.Generic;

public class Journal
{
  List<Entry> entries = new List<Entry>();
  Prompt prompt = new Prompt();
  


  public void WriteEntry()
  {
    Entry userEntry = new Entry();
    userEntry._question = prompt.PromptGenerator();
    prompt.DisplayPrompt();
    userEntry._userInput = Console.ReadLine();
    
    entries.Add(userEntry);
  }

  public void AddEntry()
  {

  }

  public void ReadEntry()
  {
    foreach (Entry entry in entries)
    {
     
      entry.DisplayEntry();
    }

  }

  public void RemoveEntry()
  {

  }



}