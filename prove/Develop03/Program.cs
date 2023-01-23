using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("Ether", "12", "26");
        Scripture scripture = new Scripture(scriptureReference, "and when I had said this, the Lord spake unto me, saying: Fools mock, but they shall mourn; and my grace is sufficient for the meek, that they shall take no advantage of your weakness;");
        ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(scripture);

        string userInput = "";

        while (userInput != "quit" && scriptureMemorizer.hasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString()));
            Console.WriteLine();
            Console.ReadLine();
            scriptureMemorizer.removeWordsFromText();
        }
    }
}