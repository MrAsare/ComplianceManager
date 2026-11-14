using ComplianceManager.Api.Data;
using ComplianceManager.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ComplianceManager.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ObligationsController : ControllerBase
{
    private readonly AppDbContext _db;
    public ObligationsController(AppDbContext db) => _db = db;

    [HttpGet]
    public async Task<IActionResult> GetAll() =>
        Ok(await _db.Obligations.ToListAsync());
        
    [HttpPost]
    public async Task<IActionResult> Create(Obligation obligation)
    {
        _db.Obligations.Add(obligation);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetAll), new { id = obligation.Id }, obligation);
    }
}