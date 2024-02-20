using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProgrammingChallenge6._1.Models;
using Microsoft.EntityFrameworkCore;
using ProgrammingChallenge6._1.ViewModels;

namespace ProgrammingChallenge6._1.Controllers
{
    public class ClubController : Controller
    {
        SchoolDbContext db;
        public ClubController(SchoolDbContext db)
        {
            this.db = db;

        }
        public async Task<IActionResult> AllClub()
        {
            var club = await db.Clubs.Include(c => c.Department).ToListAsync();
            return View(club);
        }

        public async Task<IActionResult> AddClub()
        {
            var departmentDisplay = await db.Departments.Select(
                x => new { Id = x.DepartmentID, value = x.DepartmentName }).ToListAsync();
            ClubAddClubViewModel vm = new ClubAddClubViewModel();
            vm.DepartmentList = new SelectList(departmentDisplay, "Id", "value");
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> AddClub(ClubAddClubViewModel vm)
        {
            var department = await db.Departments.SingleOrDefaultAsync(i =>
            i.DepartmentID == vm.Department.DepartmentID);
            vm.Club.Department = department;
            db.Add(vm.Club);
            await db.SaveChangesAsync();
            return RedirectToAction("AllClub");
        }
    }
}
