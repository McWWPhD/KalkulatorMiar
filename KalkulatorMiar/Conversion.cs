using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorMiar
{
    class Conversion
    {
        public double KgToFunt (double input)
        {
            return input / 0.4095;
        }

        public double FuntToKg (double input)
        {
            return input * 0.4095;
        }

        public double CelToFah (double input)
        {
            return (input * 1.8000) + 32.00;
        }

        public double FahToCel(double input)
        {
            return (input - 32) / 1.8000;
        }

        public double KmHToKts (double input)
        {
            return input * 0.539956803;
        }

        public double KtsToKmH(double input)
        {
            return input / 0.539956803;
        }

    }
}
