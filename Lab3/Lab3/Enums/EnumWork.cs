using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Enums
{
    public class EnumWork
    {
        public enum MyEnum
        {
            Profesor = 1,
            Asistent,
            Student
        }

        public static void DisplayEnum(MyEnum myEnum)
        {
            switch (myEnum)
            {
                case MyEnum.Profesor:
                    Console.WriteLine("This is the profesor");
                    break;
                case MyEnum.Asistent:
                    Console.WriteLine("This is the assitent");
                    break;
                case MyEnum.Student:
                    Console.WriteLine("This is the student");
                    break;
                default:
                    Console.WriteLine("Nothing defined");
                    break;
            }
        }
    }
}
