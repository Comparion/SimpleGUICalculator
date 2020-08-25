using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGUICalculator
{
    class CalculatorAction
    {
        public double Dodawanie(double A, double B)
        {
            return A + B;
        }
        public double Odejmowanie(double A, double B)
        {
            return A - B;
        }
        public double Dzielenie(double A, double B)
        {
            return A / B;
        }
        public double Mnozenie(double A, double B)
        {
            return A * B;
        }
    }
}
