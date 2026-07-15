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

//ordering
//method syntax
var orderedStudents = students.OrderByDescending(s => s.StudentName).ThenByDescending(s=>s.StudentAge);

//query syntax
var orderedStudentsQuery = from s in students
                           orderby s.StudentAge
                           select s;


//foreach (var student in orderedStudents)
//{
//    Console.WriteLine($"StudentName: {student.StudentName}, StudentAge: {student.StudentAge}");
//}


//set operators
List<int> FirstDigits = new List<int> { 4, 6, 7, 8, 9, 1, 1, 3, 9, 9, 10, 11 };
List<int> SecondDigits = new List<int> {1, 2, 3, 4, 5, 5, 1, 3, 9, 9, 10, 11 };

//Distinct is to eliminate duplicate values from a collection.
//It returns a new collection that contains only the unique elements
//from the original collection.
var distinctFirstDigits = FirstDigits.Distinct();

//intesect is to find the common elements between two collections.
var commonDigits = FirstDigits.Intersect(SecondDigits);

//union is to combine two collections into one collection that
//contains all the elements from both collections, without duplicates.

var unionDigits = FirstDigits.Union(SecondDigits);


//except is to find the elements that are present in one
//collection but not in another.
var exceptDigits = FirstDigits.Except(SecondDigits);

foreach (var digit in exceptDigits)
{
    Console.WriteLine($"Distinct First Digits: {digit}");
}

