//Linq can be used to query collections in a more readable and concise way.
//Here's an example of how to use LINQ in C#:
//LINQ is language integrated query,
//which allows you to query collections in a more readable and concise way.
//It provides a set of methods that can be used to filter, sort,
//and transform data in collections such as arrays, lists, and dictionaries.


List<string> Households = new List<string>
{"chairs","bed","Plates", "TV","Table","Frames","wall clock","Desk","Jug"};


//linq query
//query syntax
var result = from item in Households
             where item.Length == 3
             select item; //dapper

//foreach (var it in result)
//{
//    Console.WriteLine(it);
//}

//method syntax /fluent syntax
var result2 = Households.Where(item => item.Length == 3); //entity framework
foreach (var i in result2)
{
    Console.WriteLine(i);
}