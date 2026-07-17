//filtering e.g where
//projecting e.g select, selectmany
//ordering e.g orderby, orderbydescending, thenby, thenbydescending
//setoperators e.g union, intersect, except,Distinct
//conversion methods
//element operators
//aggregation methods
//quantifiers



//Data for the student class
using DevMatrcis;

List<Student> students = new List<Student>
{
    new Student { StudentId = 1, StudentName = "John", StudentAge = 20 },
    new Student { StudentId = 2, StudentName = "Jane", StudentAge = 22 },
    new Student { StudentId = 3, StudentName = "Bob", StudentAge = 19 },
    new Student { StudentId = 4, StudentName = "Alice", StudentAge = 21 },
    new Student { StudentId = 5, StudentName = "Tom", StudentAge = 23 },
    new Student { StudentId = 6, StudentName = "Alice", StudentAge = 24 }

};

//aggregate method
//min,max,sum,avarage,count,aggregate
var studentmax = students.Max(s => s.StudentAge);
Console.WriteLine(studentmax);

var studentmin = students.Min(s => s.StudentAge);
Console.WriteLine(studentmin);
var studentavg = students.Average(s => s.StudentAge);
Console.WriteLine(studentavg);
var studentcount = students.Count();
Console.WriteLine(studentcount);
var studentsum = students.Sum(s => s.StudentAge);
Console.WriteLine(studentsum);
var studentlongcount = students.LongCount();
Console.WriteLine(studentlongcount);

//quantifiers
//all, any, contains

var allstudentage = students.All(s => s.StudentAge > 19);
Console.WriteLine(allstudentage);
var anystudentage = students.Any(s => s.StudentAge > 23);
Console.WriteLine(anystudentage);

var std = new Student {StudentId = 3, StudentName = "Bob", StudentAge = 19  };
List<string> alphalist = new List<string> { "A", "B", "C", "D", "E" };

var containresult = students.Contains(std);
Console.WriteLine(containresult);










//conversion method
var results = students.Select(s => s.StudentName).ToList();
var result = students.Select(s => s.StudentName).ToArray();
var data = students.ToDictionary(s => s.StudentId, s => s.StudentName);

results.Sort();

////element operators
////first, firstordefault,
////last, lastordefault,
////single, singleordefault,
////elementat, elementatordefault
//List<string> alphalist = new List<string> { "A", "B", "C", "D", "E" };
//List<int> numlist = new List<int> {327, 890};
//List<string> alphalist2 = new List<string> {};
//List<int> numlist2 = new List<int> { };
////Console.WriteLine(alphalist.FirstOrDefault());
////Console.WriteLine(numlist.LastOrDefault());
////Console.WriteLine(alphalist.SingleOrDefault(x =>x =="F" ));
////Console.WriteLine(numlist.SingleOrDefault());
////Console.WriteLine(alphalist.ElementAt(10));
//Console.WriteLine(numlist.ElementAtOrDefault(2));



Console.ReadKey();