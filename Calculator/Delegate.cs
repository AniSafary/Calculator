using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Delegate
    {

        private delegate double Օperation(double a, double b);

        //public delegate Օperation Calculate(Օperation @calcualtor, char op);

        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Mult(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            return a / b;
        }

        //public static Օperation Calculated(Օperation @cal, char op)
        //{

        //    switch (op)
        //    {
        //        case '+':
        //            @cal = Add;
        //            break;
        //        case '*':
        //            @cal = Mult;
        //            break;
        //        case '/':
        //            @cal = Div;
        //            break;
        //        case '-':
        //            @cal = Sub;
        //            break;
        //        default:
        //            break;
        //    }
        //    return @cal;
        //}
    }
}
