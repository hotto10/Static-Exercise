using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        static TempConverter()
        {

        }
        public static double FahrenheitToCelsius(double f)
        {
            return (f - 32) * 5/9;
        }

        public static double CelsiusToFehrenheit(double c)
        {
            return (c * 9) / 5 + 32;
        }
    }
}
