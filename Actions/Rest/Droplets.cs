using System.Globalization;
using digitalocean_cli.Data.Rest;
using digitalocean_cli.Actions.Console;

namespace digitalocean_cli.Actions.Rest
{
    public class Droplets
    {
        private readonly string _clientId;
        private readonly string _apiKey;

        private DigitalOceanApi _api;

        public DigitalOceanApi Api
        {
            get
            {
                if (_api == null)
                {
                    _api = new DigitalOceanApi(_clientId, _apiKey);
                }

                return _api;
            }
        }

        public Droplets(string clientId, string apiKey)
        {
            _clientId = clientId;
            _apiKey = apiKey;
        }

        public void GetDroplets()
        {
            foreach (var droplet in Api.GetDroplets().Droplets)
            {
                Messages.WriteInformationalMessage("Backup Active", droplet.BackupsActive);
                Messages.WriteInformationalMessage("Droplet ID", droplet.Id.ToString(CultureInfo.InvariantCulture));
                Messages.WriteInformationalMessage("Image ID", droplet.ImageId.ToString(CultureInfo.InvariantCulture));
                Messages.WriteInformationalMessage("Name", droplet.Name);
                Messages.WriteInformationalMessage("Region ID", droplet.RegionId.ToString(CultureInfo.InvariantCulture));
                Messages.WriteInformationalMessage("Size ID", droplet.SizeId.ToString(CultureInfo.InvariantCulture));
                Messages.WriteInformationalMessage("Status", droplet.Status);
                Messages.LineBreak();
            }
        }

        public void NewDroplet(string name, int sizeId, long imageId,int regionId)
        {
            var x = Api.NewDroplet(name, sizeId, imageId, regionId).Droplet;

            Messages.WriteInformationalMessage("Droplet ID", x.Id.ToString(CultureInfo.InvariantCulture));
            Messages.WriteInformationalMessage("Name", x.Name);
            Messages.WriteInformationalMessage("Image ID", x.ImageId.ToString(CultureInfo.InvariantCulture));
            Messages.WriteInformationalMessage("Size ID", x.SizeId.ToString(CultureInfo.InvariantCulture));
            //
        }

        public void DestroyDroplet(long dropletId)
        {
            var x = Api.DestroyDroplet(dropletId);

            Messages.WriteInformationalMessage("Status", x.Status);
            Messages.WriteInformationalMessage("Event ID", x.EventId.ToString(CultureInfo.InvariantCulture));
        }

        public void RebootDroplet(long dropletId)
        {
            var x = Api.RebootDroplet(dropletId);

            Messages.WriteInformationalMessage("Status", x.Status);
            Messages.WriteInformationalMessage("Event ID", x.EventId.ToString(CultureInfo.InvariantCulture));
        }

        public void PowerCycleDroplet(long dropletId)
        {
            var x = Api.PowerCycleDroplet(dropletId);

            Messages.WriteInformationalMessage("Status", x.Status);
            Messages.WriteInformationalMessage("Event ID", x.EventId.ToString(CultureInfo.InvariantCulture));
        }

        public void ShutdownDroplet(long dropletId)
        {
            var x = Api.ShutdownDroplet(dropletId);

            Messages.WriteInformationalMessage("Status", x.Status);
            Messages.WriteInformationalMessage("Event ID", x.EventId.ToString(CultureInfo.InvariantCulture));
        }

        public void PowerOffDroplet(long dropletId)
        {
            var x = Api.PowerOffDroplet(dropletId);

            Messages.WriteInformationalMessage("Status", x.Status);
            Messages.WriteInformationalMessage("Event ID", x.EventId.ToString(CultureInfo.InvariantCulture));
        }

        public void PowerOnDroplet(long dropletId)
        {
            var x = Api.PowerOnDroplet(dropletId);

            Messages.WriteInformationalMessage("Status", x.Status);
            Messages.WriteInformationalMessage("Event ID", x.EventId.ToString(CultureInfo.InvariantCulture));
        }
        public void PasswordResetDroplet(long dropletId)
        {
            var x = Api.PasswordResetDroplet(dropletId);

            Messages.WriteInformationalMessage("Status", x.Status);
            Messages.WriteInformationalMessage("Event ID", x.EventId.ToString(CultureInfo.InvariantCulture));
        }

        public void ResizeDroplet(long dropletId, int sizeId)
        {
            var x = Api.ResizeDroplet(dropletId, sizeId);

            Messages.WriteInformationalMessage("Status", x.Status);
            Messages.WriteInformationalMessage("Event ID", x.EventId.ToString(CultureInfo.InvariantCulture));
        }

        public void SnapshotDroplet(long dropletId, string name)
        {
            var x = Api.SnapshotDroplet(dropletId, name);

            Messages.WriteInformationalMessage("Status", x.Status);
            Messages.WriteInformationalMessage("Event ID", x.EventId.ToString(CultureInfo.InvariantCulture));
        }

        public void RestoreDroplet(long dropletId, long imageId)
        {
            var x = Api.RestoreDroplet(dropletId, imageId);

            Messages.WriteInformationalMessage("Status", x.Status);
            Messages.WriteInformationalMessage("Event ID", x.EventId.ToString(CultureInfo.InvariantCulture));
        }

        public void RebuildDroplet(long dropletId, long imageId)
        {
            var x = Api.RebuildDroplet(dropletId, imageId);

            Messages.WriteInformationalMessage("Status", x.Status);
            Messages.WriteInformationalMessage("Event ID", x.EventId.ToString(CultureInfo.InvariantCulture));
        }

        public void EnableBackupsDroplet(long dropletId)
        {
            var x = Api.EnableBackupsDroplet(dropletId);

            Messages.WriteInformationalMessage("Status", x.Status);
            Messages.WriteInformationalMessage("Event ID", x.EventId.ToString(CultureInfo.InvariantCulture));
        }

        public void DisableBackupsDroplet(long dropletId)
        {
            var x = Api.DisableBackupsDroplet(dropletId);

            Messages.WriteInformationalMessage("Status", x.Status);
            Messages.WriteInformationalMessage("Event ID", x.EventId.ToString(CultureInfo.InvariantCulture));
        }

        public void RenameDroplet(long dropletId, string name)
        {
            var x = Api.RenameDroplet(dropletId, name);

            Messages.WriteInformationalMessage("Status", x.Status);
            Messages.WriteInformationalMessage("Event ID", x.EventId.ToString(CultureInfo.InvariantCulture));
        }

        public void StatusDroplet(long dropletId)
        {
            var x = Api.StatusDroplet(dropletId).Droplet;

            Messages.WriteInformationalMessage("Droplet ID", x.Id.ToString(CultureInfo.InvariantCulture));
            Messages.WriteInformationalMessage("Name", x.Name);
            Messages.WriteInformationalMessage("Image ID", x.ImageId.ToString(CultureInfo.InvariantCulture));
            Messages.WriteInformationalMessage("Size ID", x.SizeId.ToString(CultureInfo.InvariantCulture));
            Messages.WriteInformationalMessage("Region ID", x.RegionId.ToString(CultureInfo.InvariantCulture));
            Messages.WriteInformationalMessage("Locked", x.IsLocked.ToString());
            Messages.WriteInformationalMessage("Status", x.Status);
            //
        }
    }
}
