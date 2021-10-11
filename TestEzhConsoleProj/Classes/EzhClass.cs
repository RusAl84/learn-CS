using System;

namespace learnCSClasses { 

public class EzhClass
	{
		public string name;
	  public int age;
	  public  double health;

    public EzhClass(string name, int age, double health)
    {
      this.name = name;
      this.age = age;
      this.health = health;
    }
    public EzhClass(string _name, int _age)
    {
      this.name = _name;
      this.age = _age;
    }
    public EzhClass()
    {
      this.name = "no name";
      this.age = 3;
      this.health = 100;
    }
    public void Display()
		{
      if (age == 3)
      {
        Console.WriteLine($"Имя ёжика: {name}, возраст {age} года");
      }
      else
      {
        Console.WriteLine($"Имя ёжика: {name}, возраст {age} лет");
      }
    }

    public override string ToString()
    {
      return $"Имя ёжика: {name}, возраст {age} лет";
    }
  }
}