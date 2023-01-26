
// a parent class called Person
public class Person
{
    private string _studentName;

    public Person(string name)
    {
        _studentName = name;
    }

    public string GetName()
    {
        return _studentName;
    }
}

// a child class called Student
public class Student : Person
{
    private string _number;

    // calling the parent constructor using "base"!
    public Student(string name, string number) : base(name)
    {
      _number = number;
    }

    public string GetNumber()
    {
        return _number;
    }
}

public class Information :  Student
{
    private string _information;

    // calling the parent constructor using "base"!
    public Information(string name, string number, string information) : base(name,number)
    {
      _information = information;
    }

    public string GetInformation()
    {
        return _information;
    }
}


