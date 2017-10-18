using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Methods
{
    public class WorkingWithMethodsAndParams
    {
        public int Add(int x, int y)
        {
            int result = x + y;

            return result;
        }

        public void Add(int x, int y, out int result)
        {
            //Display(result.ToString());
            result = x + y;
        }

        public void MultipleOut(out int x, out bool evaluationResult, out string message)
        {
            x = Add(1, 2);
            evaluationResult = x < 2 ? true : false;
            message = x.ToString();
        }

        public void SwapStringValues(ref string s1, ref string s2)
        {
            string tempString = s1;
            s1 = s2;
            s2 = tempString;
        }

        public double CalculateAverage(params double[] values)
        {
            double avg = 0;

            if(values.Length == 0)
            {
                return avg;
            }

            int arrayLength = values.Length;

            for (int i = 0; i <= arrayLength - 1; i++)
            {
                avg += values[i];
            }

            return avg / arrayLength;
        }

        public void DisplayWithOptionalParameters(int nrOfDisplays = 1, string message = "Default message")
        {
            int i = 0;

            for(i = 0; i <= nrOfDisplays - 1; i++)
            {
                Display(message);
            }
        }

        public double Add(double x, double y)
        {
            return x + y;
        }

        public void Add(double x, double y, out double result)
        {
            result = x + y;
        }

        public void Display(string message)
        {
            Console.WriteLine("Message: {0}", message);
        }
    }
}
