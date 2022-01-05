// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("The current time is " + DateTime.Now);

using System;

namespace HelloWorld // a namespace  - use for organization
{
  class Program // a class - has member ( such as member )
  {
    static void Main(string[] args) // a method - contains a block of code
    {
      // System.Console.WriteLine("Hello World With . System"); // fully qualified name
      // Console.WriteLine("Hello World");
      // Console.WriteLine("The current time is " + DateTime.Now);
      // Create an instance ( js create new obj with new key word )
      // -------------------------------
      // Program myProgram = new Program();
      // myProgram.Print();
      Console.WriteLine(args[0]);
      // when you use two "--" between "dotnet run" and parameter So It gonna tell to the cli that the last value is a parameter and not a reserve keyword of dotnet
    }

    // void Print()
    // {
    //   System.Console.WriteLine("Hello World With . System"); // fully qualified name
    //   Console.WriteLine("Hello World");
    //   Console.WriteLine("The current time is " + DateTime.Now);
    // }
  }
}

// namespace -> classes -> method -> statements
// Two parts of a methods
// 1) you create a method
// 2) invoke a method
// *Main method does not need to invoke
// *void mean doesn't return any thing