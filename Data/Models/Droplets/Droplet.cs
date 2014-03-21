namespace digitalocean_cli.Data.Models.Droplets
{
    public class Droplet
    {
        public string BackupsActive { get; set; }
        public long Id { get; set; }
        public long ImageId { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }
        public int SizeId { get; set; }
        public string Status { get; set; }
        public bool IsLocked { get; set; }
    }
}
