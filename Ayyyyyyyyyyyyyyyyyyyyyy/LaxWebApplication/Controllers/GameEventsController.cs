using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LaxWebApplication.Models;

namespace LaxWebApplication.Controllers
{
    public class GameEventsController : Controller
    {
        private readonly GameEventsContext _context;

        public GameEventsController(GameEventsContext context)
        {
            _context = context;
        }

        // GET: GameEvents
        public async Task<IActionResult> Index()
        {
            return View(await _context.GameEvents.ToListAsync());
        }

        // GET: GameEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameEvents = await _context.GameEvents
                .SingleOrDefaultAsync(m => m.EventTime == id);
            if (gameEvents == null)
            {
                return NotFound();
            }

            return View(gameEvents);
        }

        // GET: GameEvents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GameEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Team,EventType,PenaltyType,ActingTeamMemberNumber,AssistingTeamMember,HomeScore,VisitorScore,PenaltyTime,EventTime")] GameEvents gameEvents)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gameEvents);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gameEvents);
        }

        // GET: GameEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameEvents = await _context.GameEvents.SingleOrDefaultAsync(m => m.EventTime == id);
            if (gameEvents == null)
            {
                return NotFound();
            }
            return View(gameEvents);
        }

        // POST: GameEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Team,EventType,PenaltyType,ActingTeamMemberNumber,AssistingTeamMember,HomeScore,VisitorScore,PenaltyTime,EventTime")] GameEvents gameEvents)
        {
            if (id != gameEvents.EventTime)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gameEvents);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameEventsExists(gameEvents.EventTime))
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
            return View(gameEvents);
        }

        // GET: GameEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameEvents = await _context.GameEvents
                .SingleOrDefaultAsync(m => m.EventTime == id);
            if (gameEvents == null)
            {
                return NotFound();
            }

            return View(gameEvents);
        }

        // POST: GameEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gameEvents = await _context.GameEvents.SingleOrDefaultAsync(m => m.EventTime == id);
            _context.GameEvents.Remove(gameEvents);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameEventsExists(int id)
        {
            return _context.GameEvents.Any(e => e.EventTime == id);
        }
    }
}
