using System;

namespace digitalocean_cli.Actions.Console
{
    public class Messages
    {
        public static void WriteInformationalMessage(string title, string message)
        {
            var alteredTitle = String.Format("{0}: ", title);

            System.Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.Write("{0, 15}", alteredTitle);
            System.Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine("{0}", message);
        }

        public static void WriteErrorMessgae(string message)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("{0}", message);
            System.Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void LineBreak()
        {
            System.Console.WriteLine();
        }
    }
}
