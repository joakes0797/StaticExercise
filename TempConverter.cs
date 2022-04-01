using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double temp)
        {
            return (temp - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double temp)
        {
            return (temp * 9 / 5) + 32;
        }
    }
}
