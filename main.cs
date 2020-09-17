using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Enter Name: ");
    string name = Console.ReadLine();
    Console.Write("Enter Height In Inches: ");
    double height = double.Parse(Console.ReadLine());
    Console.Write("Enter Weight In Pounds: ");
    double weight = double.Parse(Console.ReadLine());
    double BMI = (703 * weight) / (height * height);
    Console.Write("BMI: " + BMI + "\nYou Are ");
    if (BMI < 18.5) {
      Console.WriteLine("Underweight");
    }
    else if ((BMI >= 18.5) && (BMI <= 24.9)) {
      Console.WriteLine("Norman And Healthy");
    }
    else if ((BMI >= 25.0) && (BMI <= 29.9))
    {
      Console.WriteLine("Overweight");
    }
    else if (BMI >= 30)
    {
      Console.WriteLine("Obese");
    }
  }
}