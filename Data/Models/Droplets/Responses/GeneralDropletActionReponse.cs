using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalocean_cli.Data.Models.Droplets.Responses
{
    public class GeneralDropletActionReponse
    {
        public string Status { get; set; }
        public long EventId { get; set; }
    }
}
