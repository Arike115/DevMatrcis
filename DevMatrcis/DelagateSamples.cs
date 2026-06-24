using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrcis
{
    // Delegate is a type that represents references to methods with a particular
    // parameter list and return type. When you instantiate a delegate,
    // you can associate its instance with any method with a compatible
    // signature and return type. You can invoke (or call) the method through
    // the delegate instance.
    public delegate void FunctionPointer2();

    public delegate void FunctionPointer(string x);



    public class DelagateSamples1
    {

        //function or method that matches the signature of the delegate
        public static void MySampleMethod()
        {
            Console.WriteLine("Hello from MySampleMethod!");
        }   

    }

    public class DelagateSamples2
    {
        public static void MyDelegateMethd()
        {
            Console.WriteLine("Hello from MyDelegateMethd in DelagateSamples2!");
        }


        public static void MyDelegateMethd2(string x)
        {
          x = "Welcome to the the second month of the class!";
            Console.WriteLine(x);
        }

    }
}
