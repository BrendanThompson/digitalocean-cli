using System.Collections.Generic;

namespace digitalocean_cli.Data.Models.Sizes
{
    public class SizeReponse
    {
        public string Status { get; set; }
        public List<Size> Sizes { get; set; }
    }
}
