class ReflectingActivity: Activity
{
List<string> prompt, questions;

    public ReflectingActivity() : base()
    {
        setActivityName("Reflecting Activity");

        setDescription("This activity will guide and help you to reflect on times in your life when you have shown your strength and resilience. This will guide you to recognize the power you have and how you can utilize it in your different aspects of life");

        prompt = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

        questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void runActivity()
    {
        runActivityParentStart();
        displayPrompt();
        displayQuestions();
        runActivityParentEnd();
    }
    public void displayPrompt()
    {
        
        Console.Clear();
        Console.WriteLine("Consider the following");
        Console.WriteLine();

        int randomIndex = new Random().Next(0, prompt.Count());
        Console.WriteLine(prompt[randomIndex]);
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        displayCountDown(5);

        Console.Clear();
        displayQuestions();


        Console.WriteLine();
        Console.WriteLine("Well done!!!");
        displaySpinner(3);
        
    }

    public void displayQuestions()
    {
        List<int> indexes = new List<int>();
        for (int i = 1; i <4; i++)
        {
            int randomInt = new Random().Next(0, questions.Count());
            while (indexes.Contains(randomInt))
            {
                randomInt = new Random().Next(0, questions.Count());
            }
            indexes.Add(randomInt);
        }

        foreach (int index in indexes)
        {
            Console.Write(questions[index]);
            displaySpinner((userSessionLengthInput / indexes.Count()));
            Console.WriteLine();
        }
            
    }

    