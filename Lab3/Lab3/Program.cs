using Lab3.Enums;
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
