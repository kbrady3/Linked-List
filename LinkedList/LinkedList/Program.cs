using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();

            l.Add(0, 9);
            l.Add(1, 10);
            l.Add(0, 99);
            l.Add(1, 87);
            l.Remove(2);
            l.Add(2, 65);
            //l.AddLast(9876);
            Console.WriteLine("Size " + l.Size());
            

            Console.WriteLine(l.Print());

            Console.WriteLine("Peek first " + l.PeekFirst());

        }
    }
}
