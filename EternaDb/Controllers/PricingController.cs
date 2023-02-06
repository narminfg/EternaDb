using EternaDb.DAL;
using EternaDb.Models;
using EternaDb.VIewModels.PricingVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaDb.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult>  Index()
        {
            IEnumerable<Pricing> pricings = await _context.Pricings.Include(p=>p.PricingService).ToListAsync();
            IEnumerable <Service> services=await _context.Services.ToListAsync();

            PricingVM pricingVM=new PricingVM
            {
                Pricings = pricings,
                Services= services
            };
            return View(pricingVM);
        }
    }
}
