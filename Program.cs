// See https://aka.ms/new-console-template for more information
Console.WriteLine("Stack of all Stacks!");
Stack<int> myStack=new Stack<int>();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(4);
myStack.Push(5);
myStack.Push(6);
myStack.Push(7);

System.Console.WriteLine("Number of Items in Stack"+myStack.Count);
foreach(var item in myStack)
{
    System.Console.WriteLine(item);
}
Console.Read();