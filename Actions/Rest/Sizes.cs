using System.Globalization;
using digitalocean_cli.Actions.Console;
using digitalocean_cli.Data.Rest;

namespace digitalocean_cli.Actions.Rest
{
    class Sizes
    {
        private string _clientId;
        private string _apiKey;

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

        public Sizes(string clientId, string apiKey)
        {
            _clientId = clientId;
            _apiKey = apiKey;
        }
        public void GetSizes()
        {
            foreach (var size in Api.GetSizes().Sizes)
            {
                Messages.WriteInformationalMessage("Size ID", size.Id.ToString(CultureInfo.InvariantCulture));
                Messages.WriteInformationalMessage("Status", size.Name);
                Messages.LineBreak();
            }
        }
    }
}
