using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace MyContacts.Controllers
{
    [Authorize]

    public class HomeController : Controller
    {
        private readonly ContactContext _ctx;

        public HomeController(ContactContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            var contacts = _ctx.Contacts.Include(c => c.Category).OrderBy(c => c.LastName).ToList();
            return View(contacts);
        }
    }
}
