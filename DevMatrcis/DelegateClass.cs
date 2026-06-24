using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrcis
{
    public delegate bool PromoteStudentDelegate(DelegateClass students);

    public class DelegateClass
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public string Department { get; set; }
        public int Level { get; set; }
        public int Age { get; set; }

        public static void PromoteStudent(List<DelegateClass> students, PromoteStudentDelegate ipromotable)
        {
            foreach (var std in students)
            {
                if (ipromotable(std))
                {
                    std.Level += 100;
                    Console.WriteLine($"{std.Name} has been promoted to {std.Level} level ");
                }

            }
        }

        //public static void PromoteStudent(List<DelegateClass> students)
        //{
        //     foreach(var std in students)
        //    {
        //        if(std.Age <= 18 )
        //        {
        //            std.Level += 100;
        //            Console.WriteLine($"{std.Name} has been promoted to {std.Level} level ");
        //        }
               
        //    }
        //}
    }
}
