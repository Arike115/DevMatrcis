using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrcis
{
    public class UserDetails
    {
        public int Id;
        public string UserName;
        public int Age;

        //constructor
        public UserDetails(int id, string name, int age) 
        {
            Id = id;
            UserName = name;
            Age = age;

        }


        //method
        public void UserInformation()
        {
            Console.WriteLine("User Name is = " + UserName);
            Console.WriteLine("User Age is = " + Age);
        }

    }
}
