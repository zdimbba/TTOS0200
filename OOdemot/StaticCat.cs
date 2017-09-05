#region Using directivies
using System;
#endregion
namespace JAMK.IT
{
  public class Cat
  {
    //member can be accessed only via the constuctor
    private static int instances = 0;
    public Cat()
    {
      instances++;
    }
    public static void HowManyCats()
    {
      Console.WriteLine("{0} kissaa olemassa", instances);
    }
  }

  public class TestCat
  {
    public static void Testaa()
    {
      Cat.HowManyCats();//should be zero in the beginning
      Cat misse = new Cat();
      Cat.HowManyCats();//should be 1
      Cat tassu = new Cat();
      Cat.HowManyCats();//should be 2
    }
  }
}