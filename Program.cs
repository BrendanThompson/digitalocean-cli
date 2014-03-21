using System;
using System.Configuration;
using CommandLine;
using digitalocean_cli.Actions.Console;
using digitalocean_cli.Actions.Rest;
using digitalocean_cli.Data.Configuration.CommandLineArgs;
using digitalocean_cli.Data.Configuration.CommandLineArgs.SubOptions;
using digitalocean_cli.Data.Models.Droplets;

namespace digitalocean_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.Console.StaticVariables.Logo(true);
            Checks.CredentialsCheck();

            string invokedVerb = null;
            object invokedVerbInstance = null;
            var options = new Options();
            var droplets = new Droplets(ConfigurationManager.AppSettings["client_id"], ConfigurationManager.AppSettings["api_key"]);
            var sizes = new Sizes(ConfigurationManager.AppSettings["client_id"], ConfigurationManager.AppSettings["api_key"]);
            
            if (!Parser.Default.ParseArguments(args, options,
                (verb, subOptions) =>
                {
                    invokedVerb = verb;
                    invokedVerbInstance = subOptions;
                }))
            {
                Environment.Exit(Parser.DefaultExitCodeFail);
            }

            switch (invokedVerb)
            {
                case "droplet":
                {
                    var dropletOptions = (DropletOptions) invokedVerbInstance;

                    if (dropletOptions != null)
                    {
                        if (dropletOptions.List)
                        {
                            droplets.GetDroplets();
                        }
                        else if (dropletOptions.New)
                        {
                            droplets.NewDroplet(dropletOptions.Name, dropletOptions.SizeId, dropletOptions.ImageId,
                                dropletOptions.RegionId);
                        }
                        else if (dropletOptions.Destroy)
                        {
                            droplets.DestroyDroplet(dropletOptions.DropletId);
                        }
                        else if (dropletOptions.Reboot)
                        {
                            droplets.RebootDroplet(dropletOptions.DropletId);
                        }
                        else if (dropletOptions.PowerCycle)
                        {
                            droplets.PowerCycleDroplet(dropletOptions.DropletId);
                        }
                        else if (dropletOptions.Shutdown)
                        {
                            droplets.ShutdownDroplet(dropletOptions.DropletId);
                        }
                        else if (dropletOptions.PowerOff)
                        {
                            droplets.PowerOffDroplet(dropletOptions.DropletId);
                        }
                        else if (dropletOptions.PowerOn)
                        {
                            droplets.PowerOnDroplet(dropletOptions.DropletId);
                        }
                        else if (dropletOptions.PasswordReset)
                        {
                            droplets.PasswordResetDroplet(dropletOptions.DropletId);
                        }
                        else if (dropletOptions.Resize)
                        {
                            droplets.ResizeDroplet(dropletOptions.DropletId, dropletOptions.SizeId);
                        }
                        else if (dropletOptions.Snapshot)
                        {
                            droplets.SnapshotDroplet(dropletOptions.DropletId, dropletOptions.Name);
                        }
                        else if (dropletOptions.Restore)
                        {
                            droplets.RestoreDroplet(dropletOptions.DropletId, dropletOptions.ImageId);
                        }
                        else if (dropletOptions.Rebuild)
                        {
                            droplets.RebuildDroplet(dropletOptions.DropletId, dropletOptions.ImageId);
                        }
                        else if (dropletOptions.EnableBackups)
                        {
                            droplets.EnableBackupsDroplet(dropletOptions.DropletId);
                        }
                        else if (dropletOptions.DisableBackups)
                        {
                            droplets.DisableBackupsDroplet(dropletOptions.DropletId);
                        }
                        else if (dropletOptions.Rename)
                        {
                            droplets.RenameDroplet(dropletOptions.DropletId, dropletOptions.Name);
                        }
                        else if (dropletOptions.Status)
                        {
                            droplets.StatusDroplet(dropletOptions.DropletId);
                        }
                    }
                }
                    break;
                case "sizes":
                {
                    var sizeOptions = (SizeOptions) invokedVerbInstance;

                    if (sizeOptions != null && sizeOptions.List)
                    {
                        sizes.GetSizes();
                    }
                }
                    break;
            }
        }
    }
}
