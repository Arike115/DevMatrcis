using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrcis
{
    public class Calculator : Colors
    {
        public static void Add( int a , int b )
        {
            var y = a + b;
            Console.WriteLine(y);
        }
        public static void Add(double y , double x, double h)
        {
            var d = y + x * h;
            Console.WriteLine(d);
        }
        public static  void Add(int y, int  d, int x)
        {
            var f = y + d - x;
            Console.WriteLine(f);
        }

        public override void ShowColor()
        {
            throw new NotImplementedException();
        }
    }
}
