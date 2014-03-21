using System;
using System.Diagnostics;
using System.Reflection;

namespace digitalocean_cli.Data.Console
{
    class StaticVariables
    {
        public static string Logo(bool outputToConsole)
        {
            var assembly = typeof (Program).Assembly;
            var productVersion = FileVersionInfo.GetVersionInfo(assembly.Location).ProductVersion;

            string logo = String.Format(@"
BT Systems digitalocean-cli Version {0}
Copyright (c) Brendan Thompson, BT Systems 2013. All rights reserved.
digitalocean-cli command line droplet control.
-------------------------------------------------------------------------------
", productVersion);

            if (outputToConsole.Equals(true))
            {
                System.Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.BackgroundColor = ConsoleColor.Black;
                System.Console.WriteLine(logo);
                System.Console.ForegroundColor = ConsoleColor.Gray;
            }
            return logo;
        }

    }
}
