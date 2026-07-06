//stack last in first out
//queue

using System;
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);


//stack.Pop();
//Console.WriteLine(stack.Count());
//stack.Pop();
//Console.WriteLine(stack.Count());

//while (stack.Count() > 0)
//{
//   Console.WriteLine("Total" + stack.Count());
//    Console.WriteLine(stack.Pop());
//}


foreach (int i in stack)
    Console.WriteLine(i);