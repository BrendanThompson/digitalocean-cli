// System References
using System;
using System.Configuration;

// External References
using CommandLine;
using RestSharp.Extensions;

namespace digitalocean_cli.Actions.Console
{
    public class Checks
    {
        public static void CredentialsCheck()
        {
            if (!ConfigurationManager.AppSettings["client_id"].HasValue())
            {
                Messages.WriteErrorMessgae("There is no Client ID present in the configuration file.");

                Environment.Exit(Parser.DefaultExitCodeFail);
            }
            else if (!ConfigurationManager.AppSettings["api_key"].HasValue())
            {
                Messages.WriteErrorMessgae("There is no Api Key present in the configuration file.");

                Environment.Exit(Parser.DefaultExitCodeFail);
            }
        }
    }
}
