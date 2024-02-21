using Microsoft.AspNetCore.Mvc;
using ProgrammingChallenge6._1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProgrammingChallenge6._1.Controllers
{
    public class StudentController : Controller
    {
        SchoolDbContext db;
        public StudentController(SchoolDbContext db)
        {
            this.db = db;

        }
        public async Task<IActionResult> AllStudent()
        {
            var student = await db.Students.ToListAsync();
            return View(student);
        }
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddStudent(Student student)
        {
            db.Add(student);
            await db.SaveChangesAsync();
            return RedirectToAction("AllStudent");
        }
        [HttpPost]
        public async Task<IActionResult> JoinClub(Enrolment enrolment)
        {
            db.Add(enrolment);
            var course = await db.Clubs.FindAsync(enrolment.clubId);
            await db.SaveChangesAsync();
            return RedirectToAction("AllClub", "Club");
        }
    }
}
