using System.Diagnostics

class Activity
{
    private string startingMessage, endMessage, description, activityName;

    static int spinnerCounter, UserSessionLengthInput = 0;

    public Activity()
    {
        spinnerCounter = UserSessionLengthInput = 0;
    }

    public void setActivityName(string _activityName)
    {
        activityName = _activityName;
    }
    public void setDescription(string _description)
    {
        description = _description;
    }

    public int getUserSessionLengthInput()
    {
        return UserSessionLengthInput;
    }
    public void displayStartMessage()
    {
        startingMessage = string.Format("Welcome {0}.", activityName);
        Console.WriteLine(startingMessage);
        Console.WriteLine();
    }
    public void displayDescription()
    {
        Console.WriteLine(description);
        Console.WriteLine();
    }
    
    public void displayEndMessage()
    {
        endingMessage = string.Format("You have finished another {0} seconds of the {1}", UserSessionLengthInput, activityName);

        Console.WriteLine();
        Console.WriteLine("Well done!");
        displaySpinner(3);
        Console.WriteLine();
        Console.WriteLine(endingMessage);
        Console.WriteLine();
        displaySpinner(10);
    }

    public void Timer()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 <numSecondsToRun)
        {
            spinnerCounter++;
            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }

        Console.Write(" ");
    }
    public void displayCountDown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >=1; i--)
        {
        Console.Write(string.Format("You may begin in:{0}", i));
        Console.SetCursorPosition(0, Console.CursorTop);
        Thread.Sleep(1000);
        }
        
    }

    public void displayGetSessionLength()
    {
        Console.Write("How long, in seconds, would you like for your session?");
        UserSessionLengthInput = int.Parse(Console.ReadLine());
        
    }

    public void displayGetReady()
    {
        Console.WriteLine("Get ready...");
        displaySpinner(5);
    }

    public void runActivityParentStart()
    {
        displayStartingMessage();
        displayDescription();
        displayGetSessionLength();
        displayGetReady();
    }

    public void runActivityParentEnd()
    {
        displayEndingMessage();
    }
}