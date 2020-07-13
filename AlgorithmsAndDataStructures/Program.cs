using NodeChains;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //*.....*......*
            // |  3  | null *
            // *.....*......*
            Node first = new Node { Value = 3 };

            // *.....*......*    *.....*......*
            // |  3  | null *    |  5  | null *
            // *.....*......*    *.....*......*
            Node middle = new Node { Value = 5 };

            // *.....*......*    *.....*......*
            // |  3  |  *...*...>|  5  | null *
            // *.....*......*    *.....*......*
            first.Next = middle;

            // *.....*......*    *.....*......*    *.....*......*
            // |  3  |  *...*...>|  5  | null *    |  7  | null *
            // *.....*......*    *.....*......*    *.....*......*
            Node last = new Node { Value = 7 };

            // *.....*......*    *.....*......*    *.....*......*
            // |  3  |  *...*...>|  5  |  *...*...>|  7  | null *
            // *.....*......*    *.....*......*    *.....*......*
            middle.Next = last;

            // iterate over each node and print the value
            PrintList(first);
        }

        private static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
