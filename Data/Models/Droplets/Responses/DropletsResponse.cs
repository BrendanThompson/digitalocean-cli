using System.Collections.Generic;

namespace digitalocean_cli.Data.Models.Droplets.Responses
{
    public class DropletsResponse
    {
        public string Status { get; set; }
        public List<Droplet> Droplets { get; set; }
    }
}
