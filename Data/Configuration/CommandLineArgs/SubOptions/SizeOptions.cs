using CommandLine;

namespace digitalocean_cli.Data.Configuration.CommandLineArgs.SubOptions
{
    class SizeOptions : CommonOptions
    {
        [Option("List")]
        public bool List { get; set; }
    }
}
