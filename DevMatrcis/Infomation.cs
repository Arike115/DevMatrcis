using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrcis
{
    public class Infomation<T>
    {
        public int y; //field to hold an integer value
        public T v; //field to hold the value of type T

        public static void ShowEachInfo( T Info)
        {
            Console.WriteLine(Info);
        }

        public static void DisplayInfo(T Info1, T info2)
        {
            Console.WriteLine($"The information is: {Info1} and {info2}");
        }
    }
}
