using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Please enter Salesperson's name: ");
    string name = Console.ReadLine();
    Console.WriteLine ("Please enter the sales ammount: ");
    double sale = Convert.ToDouble(Console.ReadLine());

    double comm = 200 + (0.09 * sale);

    Console.WriteLine ("Sales commission for " + name + " is " + comm);

    if(sale <= 2999)
    {
      Console.WriteLine ("Preformance is poor");
    }
    else if(sale <= 4999)
    {
      Console.WriteLine ("Preformance is average");
    }
    else if(sale <= 9999)
    {
      Console.WriteLine ("Preformance is good");
    }
    else if(sale <= 14999)
    {
      Console.WriteLine ("Preformance is excellent");
    }
    else
    {
      Console.WriteLine ("Preformance is Outstanding. Congrats!");
    }
  }
}