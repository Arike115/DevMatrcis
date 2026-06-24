using DevMatrcis;

List<DelegateClass> ListOfstudent = new List<DelegateClass>();

ListOfstudent.Add(new DelegateClass { Name = "John Ajayi", Id = 101, Department = "IT", Level = 100, Age = 18 });
ListOfstudent.Add(new DelegateClass { Name = "Grace Law", Id = 102, Department = "Finance", Level = 300, Age = 25 });
ListOfstudent.Add(new DelegateClass { Name = "George Flowd", Id = 103, Department = "Chemistry", Level = 200, Age = 23 });
ListOfstudent.Add(new DelegateClass { Name = "Ola Ajayi", Id = 104, Department = "Marketing", Level = 200, Age = 28 });
ListOfstudent.Add(new DelegateClass { Name = "Shawn  Ben", Id = 105, Department = "Public Admin", Level = 300, Age = 20 });
ListOfstudent.Add(new DelegateClass { Name = "Tobi Lola", Id = 106, Department = "Mass Comm", Level = 400, Age = 23 });
ListOfstudent.Add(new DelegateClass { Name = "Aguda Grace", Id = 107, Department = "Fishery", Level = 200, Age = 21 });
ListOfstudent.Add(new DelegateClass { Name = "Cecillia Brown", Id = 108, Department = "IT", Level = 100, Age = 22 });
ListOfstudent.Add(new DelegateClass { Name = "Dupe Lawn", Id = 109, Department = "Finance", Level = 400, Age = 29 });
ListOfstudent.Add(new DelegateClass { Name = "Shola A.j", Id = 110, Department = "Marketing", Level = 300, Age = 30 });


PromoteStudentDelegate delegatestud = new PromoteStudentDelegate(PromoteStudent);
//=> lambda expression is 
DelegateClass.PromoteStudent(ListOfstudent, x => x.Level == 200 );
DelegateClass.PromoteStudent(ListOfstudent, x => x.Age <= 200);
DelegateClass.PromoteStudent(ListOfstudent, x => x.Id < 200);















static bool PromoteStudent(DelegateClass student)
{
    //return student.Age <= 18;

    if (student.Age <= 18)
    {
        return true;
    }
    else
    {
        return false;
    }
}
//static bool PromoteStudentLevel(DelegateClass student)
//{
//    //return student.Age <= 18;

//    if (student.Level <= 100)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

































//list

//int[] number = { 4, 5, 6, 7, 8, 8, 3, 3, 2, 5, 6, 9};

//List<int> listofvalues  = new List<int>();
//listofvalues.Add(1);
//listofvalues.Add(2);
//listofvalues.Add(3);
//listofvalues.Add(4);
//listofvalues.Add(5);
//listofvalues.Add(6);


//using DevMatrcis;
//using System.Reflection.Metadata.Ecma335;

//FunctionPointer2 functionPointer = DelagateSamples1.MySampleMethod;
//functionPointer();
//FunctionPointer funct = DelagateSamples2.MyDelegateMethd2;
//funct("welcome back");

//FunctionPointer funct2 = DelagateSamples2.MyDelegateMethd2;
//funct2("How are you today?");