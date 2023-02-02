using System;

public class Prompt
{
  string prompt;
  List<string> prompts = new List<string>()
  {
    "What was the best thing that happened to you today?",
"What is something that made you laugh today?",
"What steps did you take today towards a goal you’re working on?",
"Who made your day better today? How can you pay that feeling forward?",
"What made today unique?",
"What is one thing you want to remember from today?",
"When did you feel most authentically yourself today?",
"How can you make tomorrow (even) better than today?",
"What are three things you’re grateful for today?",
"What’s something that’s working well in your life right now?",
"What’s a simple pleasure in your life that you are thankful for?",
"What musician or song are you grateful for? Why?",
"Look around your room. What are some things that make you grateful?",
"What person in your life are you most thankful for?",
"What tradition in your life makes you feel grateful?",
"What experiences have you had that you are grateful for?"
  };
 

  public string PromptGenerator()
  {
    Random rndNum = new Random();
    int listSize = prompts.Count;
    int rndIndex = rndNum.Next(0, listSize);
    prompt = prompts[rndIndex];
    return prompt;
  }

  public void DisplayPrompt()
  {
    Console.WriteLine(prompt);
  }

}
