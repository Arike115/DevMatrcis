using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrcis
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Department_id { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
    }

    public enum Gender
    { 
        Male,
        Female,
        unknown

    }

}
