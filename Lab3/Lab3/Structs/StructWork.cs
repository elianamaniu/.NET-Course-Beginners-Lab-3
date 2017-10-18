using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Structs
{
    public class StructWork
    {
        public struct Point
        {
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void DisplayValues()
            {
                Console.WriteLine($"X = {X}, Y = {Y}");
            }

            public void IncrementValues()
            {
                Console.WriteLine($"X = {X++}, Y = {Y++}");
            }

            public void DecrementValues()
            {
                Console.WriteLine($"X = {X--}, Y = {Y--}");
            }
        }

        public class PointRef
        {
            public int X;
            public int Y;

            public PointRef(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void DisplayValues()
            {
                Console.WriteLine($"X = {X}, Y = {Y}");
            }

            public void IncrementValues()
            {
                Console.WriteLine($"X = {X++}, Y = {Y++}");
            }

            public void DecrementValues()
            {
                Console.WriteLine($"X = {X--}, Y = {Y--}");
            }
        }
    }
}
