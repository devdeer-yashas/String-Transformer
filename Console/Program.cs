using System;
using System.Linq;

namespace devdeer.StringManipulator.Ui.Console
{
    using Console = System.Console;

    public class Program
    {
        public static void Main(string[] args)
        {
            DisplayMenu();
            UserInput();

        }

        private static void UserInput()
        {
            throw new NotImplementedException();
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Enter the String to be transformed");
            Console.WriteLine("Enter the transformations to be applied");
            Console.WriteLine("1.LowerCaseTransformer");
            Console.WriteLine("2.UpperCaseTransformer");
            Console.WriteLine("3.RevertTransformer");
            Console.WriteLine("4.RemoveItemTransformer");
            Console.WriteLine("5.ReplaceItemTransformer");
            
            
        }
    }
}