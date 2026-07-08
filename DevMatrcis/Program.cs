//filtering e.g where
//projecting e.g select, selectmany
//ordering e.g orderby, orderbydescending, thenby, thenbydescending
//setoperators
//conversion methods
//element operators
//aggregation methods
//quantifiers


//filtering 
using DevMatrcis;

List<int > Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };   
//var Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//method syntax
var highvalues = Numbers.Where(n => n > 4);

//query syntax
var highvalues2 = from n in Numbers
                  where n > 4
                  select n;

//foreach (var k in highvalues2)
//{
//    Console.WriteLine(k);
//}


//Data for the student class
List<Student> students = new List<Student>
{
    new Student { StudentId = 1, StudentName = "John", StudentAge = 20 },
    new Student { StudentId = 2, StudentName = "Jane", StudentAge = 22 },
    new Student { StudentId = 3, StudentName = "Bob", StudentAge = 19 },
    new Student { StudentId = 4, StudentName = "Alice", StudentAge = 21 },
    new Student { StudentId = 5, StudentName = "Tom", StudentAge = 23 }
};

//projecting
//query syntax
var result = from s in students
             select new { s.StudentName, s.StudentAge };

//method syntax
var result2 = students.Select(s => new { s.StudentName, s.StudentAge });

foreach (var name in result)
{
    Console.WriteLine("Student Name: {0}, Age: {1}",name.StudentName,name.StudentAge);
}
