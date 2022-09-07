using System;
using System.Linq;

namespace devdeer.StringManipulator.Ui.Console
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class Program
    {
        #region constants

        private static readonly List<int> TransformIDs = new();

        #endregion
        #region methods

        public static void Main(string[] args)
        {
            ShowMenu();
            GetUserInput();
        }

        private static void GetUserInput()
        {
            try
            {
                var message = Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new NoNullAllowedException("You have to put in a message.");
            }
            try
            {
                var input = Console.ReadKey(true);
                {
                    while (input.Key != ConsoleKey.X)
                    {
                        switch (input.Key)
                        {
                            case ConsoleKey.D1:
                                TransformIDs.Add(1);
                                break;
                            case ConsoleKey.D2:
                                TransformIDs.Add(2);
                                break;
                            case ConsoleKey.D3:
                                TransformIDs.Add(3);
                                break;
                            case ConsoleKey.D4:
                                TransformIDs.Add(4);
                                break;
                            case ConsoleKey.D5:
                                TransformIDs.Add(5);
                                break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("String Handling Pipeline 0.1 - work in progress");
            Console.WriteLine("Put in a message you want to transform operations on.");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("The following operations are available:");
            Console.WriteLine("1 - Turn the message into all lowercase letters.");
            Console.WriteLine("2 - Turn the message into all uppercase letters.");
            Console.WriteLine("3 - Reverse the message.");
            Console.WriteLine("4 - Replace a character from the message with a character of your choice.");
            Console.WriteLine("5 - Remove a character of your choice from the message.");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("An example input could look like this:");
            Console.WriteLine("ThisIsTheMessageIWantToPerformTransformOperationsOn <Press Enter>");
            Console.WriteLine(
                "Enter the Transformation-IDs of the transformers you want to apply and then X to start the transformation:");
            Console.WriteLine("1 <Press Enter>");
            Console.WriteLine("2 <Press Enter>");
            Console.WriteLine("3 <Press Enter>");
            Console.WriteLine("4 <Press Enter>");
            Console.WriteLine("5 <Press Enter>");
            Console.WriteLine("X <Press Enter>");
        }

        #endregion
    }
}