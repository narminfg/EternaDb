using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EternaDb.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
    public IEnumerable<PricingService> PricingService { get; set; }
    }
}
