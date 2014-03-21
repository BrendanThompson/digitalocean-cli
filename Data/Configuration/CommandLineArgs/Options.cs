using CommandLine;
using digitalocean_cli.Data.Configuration.CommandLineArgs.SubOptions;

namespace digitalocean_cli.Data.Configuration.CommandLineArgs
{
    class Options
    {
        public Options()
        {
            Droplet = new SubOptions.DropletOptions();
            Sizes = new SizeOptions();
        }

        [VerbOption("droplet")]
        public DropletOptions Droplet { get; set; }
        [VerbOption("sizes")]
        public SizeOptions Sizes { get; set; }
    }
}
