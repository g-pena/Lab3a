using System;

class Program {
  public static void Main (string[] args) {
//variables
double celsius;
double farenheit;


//Ask for temp. in Celsius
Console.WriteLine("What is the temperature in Celsius?");
celsius = Convert.ToDouble(Console.ReadLine());

//Convert to Farenheit
farenheit = (celsius*9/5)+32;
Console.WriteLine("Farenheit equivalent for " + celsius);
Console.WriteLine("degree celsius is " + farenheit);

//Tell user if input is above boiling or below freezing

if (farenheit <= 32)
{
  Console.WriteLine("This temperature is below freezing of 32 degrees Farenheit.");
}

if else (farenheit >= 212)
{
  Console.WriteLine("This temperatue is above boiling of 212 degrees Farenheit.");
}








  }
}