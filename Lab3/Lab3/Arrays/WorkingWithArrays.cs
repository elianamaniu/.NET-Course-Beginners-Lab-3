using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Arrays
{
    public class WorkingWithArrays
    {
        public void ArrayInitialization()
        {
            string[] stringArray = { "BMW", "Audi", "Mercedes", "Porsche" };

            foreach(string item in stringArray)
            {
                Console.WriteLine(item);
            }
        }

        public void ImplicitArrays()
        {
            string[] stringArray = new[] { "BMW", "Audi", "Mercedes", "Porsche" };

            foreach (string item in stringArray)
            {
                Console.WriteLine(item);
            }

            var intArray = new[] { 1, 2, 3, 4, 5 };

            foreach(var item in intArray)
            {
                Console.WriteLine(item);
            }
        }

        public void DeclareArrayOfObjects()
        {
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";

            foreach (object obj in myObjects)
            {
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
        }

        public void DisplayArray(int[] intArray)
        {
            foreach(var item in intArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
