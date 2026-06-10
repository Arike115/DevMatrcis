using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrcis
{
    //method overloading
    //method overidding
    public class Student //base class
    {
        public virtual void GetStudent()
        {
            Console.WriteLine("This is a student class");
        }
        public int GetStudents(int v)
        {
            return 90;
        }

        public void GetStudent(int v, string name)
        {
            
        }
    }
}
