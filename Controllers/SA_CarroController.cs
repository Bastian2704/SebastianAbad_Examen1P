using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SebastianAbad_Examen1P.Data;
using SebastianAbad_Examen1P.Models;

namespace SebastianAbad_Examen1P.Controllers
{
    public class SA_CarroController : Controller
    {
        private readonly SebastianAbad_Examen1PContext _context;

        public SA_CarroController(SebastianAbad_Examen1PContext context)
        {
            _context = context;
        }

        // GET: SA_Carro
        public async Task<IActionResult> Index()
        {
            return View(await _context.SA_Carro.ToListAsync());
        }

        // GET: SA_Carro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sA_Carro = await _context.SA_Carro
                .FirstOrDefaultAsync(m => m.SA_CARROID == id);
            if (sA_Carro == null)
            {
                return NotFound();
            }

            return View(sA_Carro);
        }

        // GET: SA_Carro/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SA_Carro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SA_CARROID,SA_MecanicosAcargo,SA_Modelo,SA_Marca,SA_Precio,SA_Gasolina,SA_FechaEntrega")] SA_Carro sA_Carro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sA_Carro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sA_Carro);
        }

        // GET: SA_Carro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sA_Carro = await _context.SA_Carro.FindAsync(id);
            if (sA_Carro == null)
            {
                return NotFound();
            }
            return View(sA_Carro);
        }

        // POST: SA_Carro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SA_CARROID,SA_MecanicosAcargo,SA_Modelo,SA_Marca,SA_Precio,SA_Gasolina,SA_FechaEntrega")] SA_Carro sA_Carro)
        {
            if (id != sA_Carro.SA_CARROID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sA_Carro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SA_CarroExists(sA_Carro.SA_CARROID))
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
            return View(sA_Carro);
        }

        // GET: SA_Carro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sA_Carro = await _context.SA_Carro
                .FirstOrDefaultAsync(m => m.SA_CARROID == id);
            if (sA_Carro == null)
            {
                return NotFound();
            }

            return View(sA_Carro);
        }

        // POST: SA_Carro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sA_Carro = await _context.SA_Carro.FindAsync(id);
            if (sA_Carro != null)
            {
                _context.SA_Carro.Remove(sA_Carro);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SA_CarroExists(int id)
        {
            return _context.SA_Carro.Any(e => e.SA_CARROID == id);
        }
    }
}
