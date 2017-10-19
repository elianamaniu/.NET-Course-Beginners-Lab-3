using Lab3.Enums;
using Lab3.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab3.Structs.StructWork;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        #region Methods and Params

        public void WorkingWithParams()
        {
            var workingWithMethodsAndParams = new WorkingWithMethodsAndParams();

            double average;
            average = workingWithMethodsAndParams.CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", average);

            double[] data = { 4.0, 3.2, 5.7 };
            average = workingWithMethodsAndParams.CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);
        }

        public void WorkingWithDefaultValues()
        {
            var workingWithMethodsAndParams = new WorkingWithMethodsAndParams();

            workingWithMethodsAndParams.DisplayWithOptionalParameters();

            workingWithMethodsAndParams.DisplayWithOptionalParameters(4);

            workingWithMethodsAndParams.DisplayWithOptionalParameters(2, "My message");
        }

        #endregion Methods and Params

        #region Enum Work

        /// <summary>
        /// Example with Enum type
        /// </summary>
        static void EnumOperations()
        {
            var enumWork = new EnumWork();
            EnumWork.DisplayEnum(EnumWork.MyEnum.Student);
        }

        #endregion Enum Work

        #region Struct Work

        /// <summary>
        /// Working with Struct
        /// </summary>
        static void StructOperations()
        {
            Point p1;
            p1.X = 2;
            p1.Y = 3;

            p1.DisplayValues();
            p1.IncrementValues();
            p1.DisplayValues();
            p1.DecrementValues();
            p1.DisplayValues();
        }

        /// <summary>
        /// Working with struct
        /// </summary>
        static void StructOperations2()
        {
            Point p1 = new Point(10, 20);
            Point p2 = p1;

            p1.DisplayValues();
            p2.DisplayValues();
            p2.X = 100;
            p1.DisplayValues();
            p2.DisplayValues();
        }

        /// <summary>
        /// Working with class
        /// </summary>
        static void ClassOperations()
        {
            PointRef p1 = new PointRef(10, 20);
            PointRef p2 = p1;

            p1.DisplayValues();
            p2.DisplayValues();
            p2.X = 100;
            p1.DisplayValues();
            p2.DisplayValues();
        }

        #endregion Struct Work
    }
}
