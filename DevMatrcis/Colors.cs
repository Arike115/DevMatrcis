using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrcis
{
    //abstract class is a class that  cannnot be instantiated and is
    //typically used as a base class for other classes.
    //It can contain abstract methods (methods without implementation)
    //that must be implemented by derived classes,
    //as well as concrete methods (methods with implementation)
    //that can be inherited by derived classes. Abstract classes are often
    //used to define common behavior and properties for a group of related
    //classes while allowing for
    //specific implementations in the derived classes.
    public abstract class Colors : Pupils
    {
        public int x = 89;
        public string Name { get; set; }

        public void DisplayColor()
        {
            Console.WriteLine($"The color is {Name}");
        }

        public abstract void ShowColor();


    }
}
