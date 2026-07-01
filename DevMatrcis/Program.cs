//Ilist
//list
//collection
//ienumerable

List<string> names = new List<string> ();   
names.Add("John");
names.Add("Jane");
names.Add("Bob");
names.Add("Alice");
names.Add("Charlie");
names.Add("David");
names.Add("Eve");
MyIlistMethod(names);
MycollectionMethod(names);

foreach (var name in names)
{
    Console.WriteLine(name);
}
MyIEnumerableMethod(names);

static void MyIlistMethod(IList<string> myList)
{
    myList.Add("Frank");
    myList.Insert(2, "Grace");
}

static void MycollectionMethod(ICollection<string> myCollection)
{
    myCollection.Add("Hank");
    myCollection.Remove("Alice");
}   


static void MyIEnumerableMethod(IEnumerable<string> myEnumerable)
{
    var result = myEnumerable.Count();
    Console.WriteLine(result);
  
}