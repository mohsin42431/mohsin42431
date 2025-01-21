using System;

public class StackNode
{
    public int Data;
    public StackNode Next;

    public StackNode(int data)
    {
        Data = data;
        Next = null;
    }
}

public class Stack
{
    private StackNode top;

    public Stack()
    {
        top = null;
    }

    // Push operation
    public void Push(int value)
    {
        StackNode newNode = new StackNode(value);
        newNode.Next = top;
        top = newNode;
    }

    // Pop operation
    public int Pop()
    {
        if (top == null)
        {
            Console.WriteLine("Stack is empty!");
            return -1;
        }
        int poppedValue = top.Data;
        top = top.Next;
        return poppedValue;
    }

    // Peek operation
    public int Peek()
    {
        if (top == null)
        {
            Console.WriteLine("Stack is empty!");
            return -1;
        }
        return top.Data;
    }

    // Check if the stack is empty
    public bool IsEmpty()
    {
        return top == null;
    }

    // Display stack
    public void Display()
    {
        StackNode current = top;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Stack stack = new Stack();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);

        Console.WriteLine("Stack after pushing elements:");
        stack.Display();

        Console.WriteLine("Peek: " + stack.Peek());
        Console.WriteLine("Pop: " + stack.Pop());
        Console.WriteLine("Stack after popping an element:");
        stack.Display();
    }
}