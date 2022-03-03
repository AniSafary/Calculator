using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Read
    {   
        private double first;
        private double second;
        private char operation;

        public Read()
        {

            while (StringSplit(Console.ReadLine()))
            { }
        }

        private bool StringSplit(string str)
        {
            first = 0;
            second = 0;

            string currentnumber = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '+' && str[i] != '-' && str[i] != '*' && str[i] != '/'&&(str[i])>='0'&&str[i]<='9'||str[i]=='.')
                {
                    currentnumber += str[i];
                }
                else
                {
                    operation = str[i];
                    first = double.Parse(currentnumber);
                    currentnumber = "";
                }                
            }
            second= double.Parse(currentnumber);
            //Console.WriteLine("first  " + first + "   second  " + second);

            Result();
            return true;
        }

        private void Result()
        {
            double result=0;
            switch (operation)
            {
                case '+':
                    result=Delegate.Add(first, second);
                    break;
                case '*':
                    result = Delegate.Mult(first, second);
                    break;
                case '/':
                    result = Delegate.Div(first, second);
                    break;
                case '-':
                    result = Delegate.Sub(first, second);
                    break;
                default:
                    Console.WriteLine("Wrong Action");
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
