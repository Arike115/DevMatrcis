using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrcis
{
    //extension method is a special kind of static method, but they are called
    //as if they were instance methods on the extended type.

    //must be a static class to contain extension methods.
    public static class RegionSet
    {
        
        //must be static  method
        //first parameter use 'this' keyword followed by the type
        //that the method extends.
        public static int RegionCount(this string input)
        {
            
            if (string.IsNullOrWhiteSpace(input))
                return 0;
            
            var result = input.Split(new char[] { ' ', '\t', '\n' }, 
                StringSplitOptions.RemoveEmptyEntries);
            return result.Length;

        }
    }
}
