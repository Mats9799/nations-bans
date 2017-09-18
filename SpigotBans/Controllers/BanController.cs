using Microsoft.AspNetCore.Mvc;
using SpigotBans.Models;

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
            return View(repository.GetBans());
        }
    }
}
