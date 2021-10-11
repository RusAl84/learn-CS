using System;
using Newtonsoft;
using learnCSClasses;

namespace learn_CS
{
  class Program
  {
    static void Main(string[] args)
    {
      //Console.WriteLine("Hello World!");
      //Console.Beep();
      //int a = 5;
      //Console.WriteLine(a);
      EzhClass ezhik = new EzhClass();
      ezhik.name = "Anton";
      ezhik.age = 17;
      ezhik.Display();
    
    }

  }
}
