using System;

namespace StatisticsHelper
{
    public class Program
    {
        public enum MenuAction { PercentageCalculator, Quit, GetRandomNumber, SumNumbers }

        public static void Main()
        {
            Console.WriteLine("Hello, welcome to statistics helper...\n\tBy Zach & Paula Hollis");

            while (true)
            {
                PrintMenu();

                var action = GetMenuAction();
                if (action == MenuAction.Quit)
                {
                    return;
                }

                CallAction(action);
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine(
                "\nPlease type the corresponding letter to select a helper..." +
                "\n\tP: Percentage Calculator" +
                "\n\tR: Random Number" +
                "\n\tS: Sum Numbers" +
                "\n\n\tQ: Quit the Program"
                );
        }

        private static MenuAction GetMenuAction()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    continue;

                char command = char.ToUpper(input[0]);

                if (command == 'P')
                    return MenuAction.PercentageCalculator;
                else if (command == 'Q')
                    return MenuAction.Quit;
                else if (command == 'R')
                    return MenuAction.GetRandomNumber;
                else if (command == 'S')
                    return MenuAction.SumNumbers;
            }
        }

        private static void CallAction(MenuAction action)
        {
            if (action == MenuAction.PercentageCalculator)
            {
                Chapter1.CalculatePercentage();
            }
            else if (action == MenuAction.GetRandomNumber)
            {
                Chapter1.GetRandomNumber();
            }
            else if (action == MenuAction.SumNumbers)
            {
                Chapter1.SumNumbers();
            }
        }
    }
}
