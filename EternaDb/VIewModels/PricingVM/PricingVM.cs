using EternaDb.Models;

namespace EternaDb.VIewModels.PricingVM
{
    public class PricingVM
    {
        public IEnumerable<Pricing> Pricings { get; set; }
        public IEnumerable<Service> Services { get; set; }
    }
}
