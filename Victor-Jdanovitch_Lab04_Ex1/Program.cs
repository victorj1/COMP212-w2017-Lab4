using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victor_Jdanovitch_Lab04_Ex1
{
    class Program
    {
        private static int[] intElements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        private static Stack<int> intStack; // stack stores ints  

        static void Main(string[] args)
        {
            intStack = new Stack<int>(10); // stack of ints

            TestPushInt(); // push ints onto intStack
            TestPeekInt(); // peek ints from intStack
            TestPopInt(); // pop ints from intStack
            TestPeekInt(); // peek ints from intStack
        }

        // test Push method with intStack
        private static void TestPushInt()
        {
            // push elements onto stack
            try
            {
                Console.WriteLine("\nPushing elements onto intStack");

                // push elements onto stack
                foreach (var element in intElements)
                {
                    Console.Write($"{element} ");
                    intStack.Push(element); // push onto intStack
                }
            }
            catch (StackOverflowException exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                Console.Error.WriteLine(exception.StackTrace);
            }
        }

        // test Pop method with intStack
        private static void TestPopInt()
        {
            // pop elements from stack
            try
            {
                Console.WriteLine("\nPopping elements from intStack");

                int popValue; // stores element removed from stack
                bool counter = true;
                // remove all elements from stack
                while (counter)
                {
                    popValue = intStack.Pop(); // pop from intStack
                    Console.Write($"{popValue:F1} ");
                    if (popValue == 8)
                    {
                        counter = false;
                    }
                }
            }
            catch (Exception exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                Console.Error.WriteLine(exception.StackTrace);
            }
        }

        private static void TestPeekInt()
        {
            Console.WriteLine($"\nTop elements in the Stack: {intStack.Peek()}");
        }
    }
}
