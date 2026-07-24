//path
string path = @"C:\Document\Vocabulary.txt";
string Sentence = "Hello, we are here";

File.WriteAllText(path, Sentence);

var value =File.ReadAllText(path);
Console.WriteLine(value);

var valu2 = Directory.GetParent(path);
Console.WriteLine(valu2);