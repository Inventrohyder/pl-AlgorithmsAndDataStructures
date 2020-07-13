using Stack.List;
using System;

namespace Calculator
{
class Program
    {
       // calc.exec 5 6 7 * + 1 -
       static void Main(string[] args)
       {
           // The stack of integers not yet operated on
           Stack<int> values = new Stack<int>();

           String[] arguments = getArguments();

           foreach (string token in arguments)
           {
               // if the value is an integer...
               int value;
               if (int.TryParse(token, out value))
               {
                   // ... push it to the stack
                   values.Push(value);
               }
               else
               {
                   // otherwise evaluate the expression...
                   int rhs = values.Pop();
                   int lhs = values.Pop();

                   // ... and push the result back to the stack
                   switch (token)
                   {
                       case "+":
                           values.Push(lhs + rhs);
                           break;
                       case "-":
                           values.Push(lhs - rhs);
                           break;
                       case "*":
                           values.Push(lhs * rhs);
                           break;
                       case "/":
                           values.Push(lhs / rhs);
                           break;
                       case "%":
                           values.Push(lhs % rhs);
                           break;
                       default:
                           throw new ArgumentException(string.Format("Unexpected token {0}", token));
                   }
               }
           }

           // the last item on the stack is the result
           Console.WriteLine(values.Pop());
       }

       private static string[] getArguments()
       {
           String operation = Console.ReadLine();
           return operation.Split();
       }
    }
}
