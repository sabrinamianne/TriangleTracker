using System;

public class Triangle
{
  public static void Main()
  {
    Console.WriteLine("Welcome to our application, If you want to know which type is your triangle, please enter the value of the three sides of it.");
    Console.WriteLine("Please enter a number for the First Side:  ");
    string FirstSideStr = Console.ReadLine();
    int FirstSide = int.Parse(FirstSideStr);
    Console.WriteLine("Please enter a number for the Second Side:");
    string SecondSideStr = Console.ReadLine();
    int SecondSide = int.Parse(SecondSideStr);
    Console.WriteLine("Please enter a number for the Third Side: ");
    string ThirdSideStr = Console.ReadLine();
    int ThirdSide = int.Parse(ThirdSideStr);

    if (FirstSide == SecondSide && SecondSide == ThirdSide )
    {
      Console.WriteLine("Your Triangle is an Equilateral");
    }
    else if (FirstSide == SecondSide && FirstSide + SecondSide> ThirdSide || SecondSide == ThirdSide && SecondSide + ThirdSide > FirstSide|| FirstSide == ThirdSide && FirstSide + ThirdSide > SecondSide)
    {
      Console.WriteLine("Your Triangle is an Isosceles:");
    }
    else if (FirstSide != SecondSide && FirstSide + SecondSide > ThirdSide && SecondSide != ThirdSide && SecondSide + ThirdSide >FirstSide && FirstSide != ThirdSide && FirstSide + ThirdSide > SecondSide)
    {
      Console.WriteLine("Your Triangle is a Scalene:");
    }
    else
    {
      Console.WriteLine("I don't think that your triangle is...a triangle.");
    }
  }
}
