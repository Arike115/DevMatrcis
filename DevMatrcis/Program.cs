//queue first in first out
//Dictionary is a collection of key value pairs, which is used to store data in a
//key value pair format. It is similar to a list,
//but it allows you to access values using keys instead of indexes.
// The Dictionary class is a generic collection,
// which means that you can specify the type of keys and values that it will store.
// The Dictionary class provides methods for adding,
// removing, and accessing key value pairs,
// as well as for checking if a key exists in the dictionary.

using System;

Dictionary<int, string> dictionaryValues = new Dictionary<int, string>();
dictionaryValues.Add(1,"C#");
dictionaryValues.Add(2,"Java");
dictionaryValues.Add(3,"Python");
dictionaryValues.Add(4,"JavaScript");
dictionaryValues.Add(5,"C++");  

foreach (var item in dictionaryValues)
{
    Console.WriteLine("Chapter: " + item.Key + ", Value: " + item.Value);
}









//Queue<string> queue = new Queue<string>();    
//queue.Enqueue("Toyota");
//queue.Enqueue("Honda");
//queue.Enqueue("Ford");
//queue.Enqueue("Chevrolet");
//queue.Enqueue("Nissan");

//Console.WriteLine("the total count is " + queue.Count());
//Console.WriteLine("the first element is " + queue.Dequeue()); 
//Console.WriteLine("the final total count is " + queue.Count());
//Console.WriteLine("the first element is " + queue.Dequeue());
//Console.WriteLine("the final total count is " + queue.Count());


