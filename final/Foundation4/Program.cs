using System;

namespace Inheritance {

  // base class
  class Siblings { 

    public string name;

    public void display() {
      Console.WriteLine("I am Orphee's brother");
    }
    
  } 
  
  // derived class of Animal 
  class Men : Siblings {
    
    public void getName() {
      Console.WriteLine("My name is " + name);
    }
  }

  class Program {

    static void Main(string[] args) {

      // object of derived class
      Men boy = new Men();

      // access field and method of base class
      boy.name = "Nelson";
      boy.display();

      // access method from own class
      boy.getName();

      Console.ReadLine();
    }

  }
}