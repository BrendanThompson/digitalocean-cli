using CommandLine;

namespace digitalocean_cli.Data.Configuration.CommandLineArgs.SubOptions
{
    class DropletOptions : CommonOptions
    {
        [Option("List")]
        public bool List { get; set; }
        [Option("new")]
        public bool New { get; set; }
        [Option("destroy")]
        public bool Destroy { get; set; }
        [Option("reboot")]
        public bool Reboot { get; set; }
        [Option("power-cycle")]
        public bool PowerCycle { get; set; }
        [Option("shutdown")]
        public bool Shutdown { get; set; }
        [Option("power-off")]
        public bool PowerOff { get; set; }
        [Option("power-on")]
        public bool PowerOn { get; set; }
        [Option("password-reset")]
        public bool PasswordReset { get; set; }
        [Option("resize")]
        public bool Resize { get; set; }
        [Option("snapshot")]
        public bool Snapshot { get; set; }
        [Option("restore")]
        public bool Restore { get; set; }
        [Option("rebuild")]
        public bool Rebuild { get; set; }
        [Option("enable-backups")]
        public bool EnableBackups { get; set; }
        [Option("disable-backups")]
        public bool DisableBackups { get; set; }
        [Option("rename")]
        public bool Rename { get; set; }
        [Option("status")]
        public bool Status { get; set; }
        
        // Options
        [Option("name")]
        public string Name { get; set; }
        [Option("size")]
        public int SizeId { get; set; }
        [Option("image")]
        public long ImageId { get; set; }
        [Option("region")]
        public int RegionId { get; set; }
        [Option("droplet-id")]
        public long DropletId { get; set; }
    }
}
