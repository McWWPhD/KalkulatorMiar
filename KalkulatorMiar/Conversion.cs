using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorMiar
{
    static class Conversion
    {
        public static double KgToFunt (double input)
        {
            return input / 0.4095;
        }

        public static double FuntToKg (double input)
        {
            return input * 0.4095;
        }

        public static double CelToFah (double input)
        {
            return (input * 1.8000) + 32.00;
        }

        public static double FahToCel(double input)
        {
            return (input - 32) / 1.8000;
        }

        public static double KmHToKts (double input)
        {
            return input * 0.539956803;
        }

        public static double KtsToKmH(double input)
        {
            return input / 0.539956803;
        }

    }
}
