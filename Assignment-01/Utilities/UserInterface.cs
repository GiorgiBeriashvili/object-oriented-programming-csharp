using System;

namespace Assignment_01.Utilities
{
    public static class UserInterface
    {
        public static void DisplayUsers()
        {
            int index;

            PrintLine("Choose the message recipient from the user list below:");

            for (index = 0; index < Program.Users.Count; index++)
            {
                PrintLine($"{index + 1} - {Program.Users[index].FirstName} {Program.Users[index].LastName}");
            }

            PrintLine($"{++index} - Other...");
        }

        public static void PromptRestart()
        {
            Print("\nWould you like to send another message? (Y/n): ");

            var restart = Console.ReadKey();

            if (restart.Key == ConsoleKey.N)
            {
                Program.Running = false;
            }
            else
            {
                PrintLine("\n");
            }
        }

        public static void Print(string value)
        {
            Console.Write(value);
        }

        public static void PrintLine(string value)
        {
            Console.WriteLine(value);
        }

        public static string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}