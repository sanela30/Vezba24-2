using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba24._2
{
    internal class SimpleCalc
    {

        public static double Calc(string operation, double num1, double num2)
        {
            switch (operation)
            {
                case "+":
                    return num1+num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                default:
                    return 0;
            }
        }
    }
}
