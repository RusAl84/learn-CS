using System;
using System.IO;
using Newtonsoft;
using learnCSClasses;
using Newtonsoft.Json;

namespace learn_CS
{
  class Program
  {
    public static int Sound(int a)
    {
      for (int i = 0; i < 5; i++)
        Console.Beep(3000 - 100 * i, 1000-i*100) ;
      return a*a;
    }
    public static void SoundTiiii()
    {
        Console.Beep(3000, 3000 );
    }
    static void Main(string[] args)
    {
      //int b = Sound(5);
      //Console.WriteLine(b);
      //Console.Beep(3000, 3000);
      //Console.WriteLine("Hello World!");
      //Console.Beep();
      //int a = 5;
      //Console.WriteLine(a);
      EzhClass ezhik = new EzhClass("Anton", 17);
      //ezhik.age = 3;
      //ezhik.Display();      
      //ezhik.age = 17;
      //ezhik.Display();
      Console.WriteLine(ezhik);
      string jsonString = JsonConvert.SerializeObject(ezhik);
      Console.WriteLine(jsonString);
      string fileName = "json.txt";
      File.WriteAllText(fileName, jsonString);
      EzhClass restoredEzhik = new();
      if (File.Exists(fileName)) 
      { 
        string restoredJsonString = File.ReadAllText(fileName);
        restoredEzhik = JsonConvert.DeserializeObject<EzhClass>(restoredJsonString);
      }
      Console.WriteLine(restoredEzhik);

    }

  }
}
