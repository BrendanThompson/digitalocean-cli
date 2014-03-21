using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalocean_cli.Data.Models.Droplets.Responses
{
    public class DropletResponse
    {
        public string Status { get; set; }
        public Droplet Droplet { get; set; }
    }
}
