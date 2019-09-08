using Grabble.Data.Domain;
using Grabble.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Grabble.Grabbler.Mvc.Controllers
{
    public class FamiliarController : Controller
    {
        private readonly FamiliarContext _context;

        public FamiliarController(FamiliarContext context)
        {
            _context = context;
        }

        // GET: Familiar
        public async Task<IActionResult> Index()
        {
            return View(await _context.FamiliarDbContext.ToListAsync());
        }

        // GET: Familiar/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familiar = await _context.FamiliarDbContext
                .FirstOrDefaultAsync(m => m.Id == id);
            if (familiar == null)
            {
                return NotFound();
            }

            return View(familiar);
        }

        // GET: Familiar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Familiar/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FamiliarGuid,Username,Firstname,Lastname,Email,Phone,EmailToRevalidate,FlightId,Id,CreateDate,CreateBy,ModifyDate,ModifyBy,IPAddress")] Familiar familiar)
        {
            if (ModelState.IsValid)
            {
                familiar.FamiliarGuid = Guid.NewGuid();
                familiar.Username = "NeWFamiliarGrabbler";
                _context.Add(familiar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Confirmation));
            }
            return View(familiar);
        }

        // GET: Familiar/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familiar = await _context.FamiliarDbContext.FindAsync(id);
            if (familiar == null)
            {
                return NotFound();
            }
            return View(familiar);
        }

        // POST: Familiar/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("FamiliarGuid,Username,Firstname,Lastname,Email,Phone,EmailToRevalidate,FlightId,Id,CreateDate,CreateBy,ModifyDate,ModifyBy,IPAddress")] Familiar familiar)
        {
            if (id != familiar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(familiar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FamiliarExists(familiar.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(familiar);
        }

        // GET: Familiar/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familiar = await _context.FamiliarDbContext
                .FirstOrDefaultAsync(m => m.Id == id);
            if (familiar == null)
            {
                return NotFound();
            }

            return View(familiar);
        }

        // POST: Familiar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var familiar = await _context.FamiliarDbContext.FindAsync(id);
            _context.FamiliarDbContext.Remove(familiar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FamiliarExists(long id)
        {
            return _context.FamiliarDbContext.Any(e => e.Id == id);
        }

        public IActionResult Confirmation()
        {
            return Content("Thank you for using Grabble");
        }
    }
}
