using Microsoft.AspNetCore.Mvc;
using ProgrammingChallenge6._1.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Diagnostics;


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
            //var department = await  db.Departments.ToListAsync<Department>();
            return View(department);
        }
        public IActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddDepartment(Department department)
        {
            db.Add(department);
            await db.SaveChangesAsync();
            return RedirectToAction("AllDepartment");
        }
    }
}
