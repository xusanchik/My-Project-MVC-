using Gumbaz.Data;
using Gumbaz.Entity;
using Gumbaz.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gumbaz.Controllers
{
    public class WorkController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public WorkController( AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Save(Coment coment)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            _appDbContext.Coments.Add(coment);
            await _appDbContext.SaveChangesAsync();

            var lis = await _appDbContext.Coments.ToListAsync();
            return RedirectToAction(nameof(Index));
            
        } 

    }
}
