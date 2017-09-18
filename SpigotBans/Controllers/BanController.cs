using Microsoft.AspNetCore.Mvc;
using SpigotBans.Models;
using System.Linq;

namespace SpigotBans.Controllers
{
    public class BanController : Controller
    {
        private IBanRepository repository;

        public BanController(IBanRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View(repository.GetBans().OrderByDescending(b => b.BanDate).Take(100));
        }
    }
}
