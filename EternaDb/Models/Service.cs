namespace EternaDb.Models
{
    public class Service
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        public IEnumerable<PricingService> PricingService { get; set; }
    }
}
}
