public class Prompt
{
    List<string> _prompts;// = new List<string>();

    public Prompt()
    {
        _prompts = new List<string>() 
        {
        "What did I learn today?",
        "How I prepared myself to receive God revelations today?",
        "What I learned from my daily choice today?",
        "Do I have something I need to repent?",
        "Do I spend enough time with my family members today?"
        };
    }


    public void displayPrompt()
    {
        Random dom = new Random();
        int index = dom.Next(0, _prompts.Count());
        Console.WriteLine(String.Format("{0}", _prompts[index]));
    }
   
}
