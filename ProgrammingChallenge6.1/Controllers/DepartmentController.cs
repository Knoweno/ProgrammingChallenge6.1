using Microsoft.AspNetCore.Mvc;
using ProgrammingChallenge6._1.Models;
using System.Data.Entity;

namespace ProgrammingChallenge6._1.Controllers
{
    public class DepartmentController : Controller
    {
        SchoolDbContext db;
        public DepartmentController(SchoolDbContext db)
        {
            this.db = db;

        }
        public async Task<IActionResult> AllDepartment()
        {
            var department = await db.Departments.ToListAsync();
            return View(department);
        }
        public IActionResult AddDepartmentr()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddDepartmentr(Department department)
        {
            db.Add(department);
            await db.SaveChangesAsync();
            return RedirectToAction("AllDepartment");
        }
    }
}
