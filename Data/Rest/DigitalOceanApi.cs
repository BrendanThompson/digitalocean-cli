using System;
using digitalocean_cli.Actions.Console;
using digitalocean_cli.Data.Models.Droplets;
using digitalocean_cli.Data.Models.Droplets.Responses;
using digitalocean_cli.Data.Models.Sizes;
using RestSharp;

namespace digitalocean_cli.Data.Rest
{
    public class DigitalOceanApi
    {
        private const string BASE_URL = "https://api.digitalocean.com/";
        private readonly string _clientId;
        private readonly string _apiKey;
        private readonly RestClient _client;

        public DigitalOceanApi(string clientId, string apiKey)
        {
            _clientId = clientId;
            _apiKey = apiKey;

            _client = new RestClient(BASE_URL);
        }

        private T Execute<T>(RestRequest request) where T : new()
        {
            var response = _client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error Retrieving reponse. Check inner details for more info.";
                var digitalOceanApiException = new ApplicationException(message, response.ErrorException);
                Messages.WriteErrorMessgae(response.ErrorMessage);
                throw digitalOceanApiException;
            }

            return response.Data;
        }

        private RestRequest GetRequest(string endpoint)
        {
            var request = new RestRequest(endpoint);
            request.AddParameter("client_id", _clientId, ParameterType.GetOrPost);
            request.AddParameter("api_key", _apiKey, ParameterType.GetOrPost);

            return request;
        }

        public DropletsResponse GetDroplets()
        {
            var request = GetRequest("droplets");

            return Execute<DropletsResponse>(request);
        }

        public DropletResponse NewDroplet(string name, int sizeId, long imageId, int regionId)
        {
            var request = GetRequest("droplets/new");
            request.AddParameter("name", name, ParameterType.GetOrPost);
            request.AddParameter("size_id", sizeId, ParameterType.GetOrPost);
            request.AddParameter("image_id", imageId, ParameterType.GetOrPost);
            request.AddParameter("region_id", regionId, ParameterType.GetOrPost);

            return Execute<DropletResponse>(request);
        }

        public GeneralDropletActionReponse DestroyDroplet(long dropletId)
        {
            var request = GetRequest("droplets/{droplet_id}/destroy");
            request.AddParameter("droplet_id", dropletId, ParameterType.UrlSegment);

            return Execute<GeneralDropletActionReponse>(request);
        }

        public GeneralDropletActionReponse RebootDroplet(long dropletId)
        {
            var request = GetRequest("droplets/{droplet_id}/reboot");
            request.AddParameter("droplet_id", dropletId, ParameterType.UrlSegment);

            return Execute<GeneralDropletActionReponse>(request);
        }

        public GeneralDropletActionReponse PowerCycleDroplet(long dropletId)
        {
            var request = GetRequest("droplets/{droplet_id}/power_cycle");
            request.AddParameter("droplet_id", dropletId, ParameterType.UrlSegment);

            return Execute<GeneralDropletActionReponse>(request);
        }

        public GeneralDropletActionReponse ShutdownDroplet(long dropletId)
        {
            var request = GetRequest("droplets/{droplet_id}/shutdown");
            request.AddParameter("droplet_id", dropletId, ParameterType.UrlSegment);

            return Execute<GeneralDropletActionReponse>(request);
        }

        public GeneralDropletActionReponse PowerOffDroplet(long dropletId)
        {
            var request = GetRequest("droplets/{droplet_id}/power_off");
            request.AddParameter("droplet_id", dropletId, ParameterType.UrlSegment);

            return Execute<GeneralDropletActionReponse>(request);
        }

        public GeneralDropletActionReponse PowerOnDroplet(long dropletId)
        {
            var request = GetRequest("droplets/{droplet_id}/power_on");
            request.AddParameter("droplet_id", dropletId, ParameterType.UrlSegment);

            return Execute<GeneralDropletActionReponse>(request);
        }
        public GeneralDropletActionReponse PasswordResetDroplet(long dropletId)
        {
            var request = GetRequest("droplets/{droplet_id}/password_reset");
            request.AddParameter("droplet_id", dropletId, ParameterType.UrlSegment);

            return Execute<GeneralDropletActionReponse>(request);
        }

        public GeneralDropletActionReponse ResizeDroplet(long dropletId, int sizeId)
        {
            var request = GetRequest("droplets/{droplet_id}/resize");
            request.AddParameter("droplet_id", dropletId, ParameterType.UrlSegment);
            request.AddParameter("size_id", sizeId, ParameterType.GetOrPost);

            return Execute<GeneralDropletActionReponse>(request);
        }

        public GeneralDropletActionReponse SnapshotDroplet(long dropletId, string name)
        {
            var request = GetRequest("droplets/{droplet_id}/snapshot");
            request.AddParameter("droplet_id", dropletId, ParameterType.UrlSegment);
            request.AddParameter("name", name, ParameterType.GetOrPost);

            return Execute<GeneralDropletActionReponse>(request);
        }

        public GeneralDropletActionReponse RestoreDroplet(long dropletId, long imageId)
        {
            var request = GetRequest("droplets/{droplet_id}/restore");
            request.AddParameter("droplet_id", dropletId, ParameterType.UrlSegment);
            request.AddParameter("image_id", imageId, ParameterType.GetOrPost);

            return Execute<GeneralDropletActionReponse>(request);
        }

        public GeneralDropletActionReponse RebuildDroplet(long dropletId, long imageId)
        {
            var request = GetRequest("droplets/{droplet_id}/rebuild");
            request.AddParameter("droplet_id", dropletId, ParameterType.UrlSegment);
            request.AddParameter("image_id", imageId, ParameterType.GetOrPost);

            return Execute<GeneralDropletActionReponse>(request);
        }

        public GeneralDropletActionReponse EnableBackupsDroplet(long dropletId)
        {
            var request = GetRequest("droplets/{droplet_id}/enable_backups");
            request.AddParameter("droplet_id", dropletId, ParameterType.UrlSegment);

            return Execute<GeneralDropletActionReponse>(request);
        }

        public GeneralDropletActionReponse DisableBackupsDroplet(long dropletId)
        {
            var request = GetRequest("droplets/{droplet_id}/disable_backups");
            request.AddParameter("droplet_id", dropletId, ParameterType.UrlSegment);

            return Execute<GeneralDropletActionReponse>(request);
        }

        public GeneralDropletActionReponse RenameDroplet(long dropletId, string name)
        {
            var request = GetRequest("droplets/{droplet_id}/rename");
            request.AddParameter("droplet_id", dropletId, ParameterType.UrlSegment);
            request.AddParameter("name", name, ParameterType.GetOrPost);

            return Execute<GeneralDropletActionReponse>(request);
        }

        public DropletResponse StatusDroplet(long dropletId)
        {
            var request = GetRequest("droplets/{droplet_id}");
            request.AddParameter("droplet_id", dropletId, ParameterType.UrlSegment);

            return Execute<DropletResponse>(request);
        }

        public SizeReponse GetSizes()
        {
            var request = GetRequest("sizes");

            return Execute<SizeReponse>(request);
        }
    }
}