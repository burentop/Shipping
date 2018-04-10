using System;

class Shipping
{
  static void Main()
  {
    AskForInput("package weight");
    int packageWeight = int.Parse(Console.ReadLine());
    AskForInput("distance");
    int distanceToTravel = int.Parse(Console.ReadLine());
    AskForInput("price modifier");
    int modifier = int.Parse(Console.ReadLine());

    int price = (packageWeight / 10) + (distanceToTravel / 5) * modifier;

    Console.WriteLine("Your total price is: $" + price);
  }

  static void AskForInput(string item)
  {
    Console.WriteLine("What is the " + item + ": ");
  }
}