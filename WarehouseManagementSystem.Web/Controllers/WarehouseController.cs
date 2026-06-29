using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseManagementSystem.Domain.Entities;
using WarehouseManagementSystem.Infrastructure.Persistence;

namespace WarehouseManagementSystem.Web.Controllers;

public class WarehouseController : Controller
{
    private readonly ApplicationDbContext _context;

    public WarehouseController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Warehouse
    public async Task<IActionResult> Index()
    {
        var warehouses = await _context.Warehouses.ToListAsync();
        return View(warehouses);
    }

    // GET: Warehouse/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Warehouse/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Warehouse warehouse)
    {
        if (ModelState.IsValid)
        {
            _context.Warehouses.Add(warehouse);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        return View(warehouse);
    }
}