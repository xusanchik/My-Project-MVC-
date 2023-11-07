using Gumbaz.Data;
using Gumbaz.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gumbaz.Controllers
{
    public class ContactController : Controller
    {

        private readonly AppDbContext _appContext;
        public ContactController(AppDbContext appDbContext) => _appContext = appDbContext;
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Save(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View("Error");
            }
            _appContext.Contacts.Add(contact);
            await _appContext.SaveChangesAsync();

            var lis = await _appContext.Contacts.ToListAsync();

            return RedirectToAction(nameof(Index));


        }
    }
}
