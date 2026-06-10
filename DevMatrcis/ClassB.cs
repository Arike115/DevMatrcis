using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrcis
{
    //derived class
    public class ClassB : ClassA,IStudent
    {
        public void Click()
        {
            throw new NotImplementedException();
        }

        public void Migrate()
        {
            throw new NotImplementedException();
        }

        //method
        public string  ValueMethod()
        {
            string x = "Hello";
            Console.WriteLine(x);
            return x;
        }

        public int Values()
        {
            throw new NotImplementedException();
        }
    }


    public class ClassC : ClassB
    { 
    
    
    
    }

}
