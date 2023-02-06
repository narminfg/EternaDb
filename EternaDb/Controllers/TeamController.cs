using EternaDb.DAL;
using EternaDb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EternaDb.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        public TeamController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Team> teams = _context.teams.ToList();

            return View(teams);
        }
    }
}
