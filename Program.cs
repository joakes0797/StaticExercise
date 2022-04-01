using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValidTemp;
            double result;

            Console.WriteLine("Welcome to the Temperature Converter.");
            
            do
            {
                Console.Write("Enter the temperature in Fahrenheit that you wish to convert: ");
                isValidTemp = double.TryParse(Console.ReadLine(), out result);
            }while (!isValidTemp);

            Console.WriteLine($"{result} degrees Fahrenheit is the same as {TempConverter.FahrenheitToCelsius(result)} degrees Celsius.");
            
            Console.WriteLine("----------");
            
            bool isValidTemp2;
            double result2;
            do
            {
                Console.Write("Enter the temperature in Celsius that you wish to convert: ");
                isValidTemp2 = double.TryParse(Console.ReadLine(), out result2);
            } while (!isValidTemp2);

            Console.WriteLine($"{result2} degrees Celsius is the same as {TempConverter.CelsiusToFahrenheit(result2)} degrees Fahrenheit.");
        }
    }
}
