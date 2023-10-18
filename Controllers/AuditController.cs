using CrudMVCByKING.Data;
using CrudMVCByKING.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudMVCByKING.Controllers
{
    public class AuditController : Controller

   
    {
        private readonly UsersDbContext _context;

        public AuditController(UsersDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult >Index()
        {
            var audits = await _context.AuditTrailRecords.ToListAsync();

            return View(audits);

        }

     
    }
}
