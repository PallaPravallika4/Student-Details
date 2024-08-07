using Microsoft.AspNetCore.Mvc;
using StudentInformation.Data;
using StudentInformation.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentInformation.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext _context;

        public StudentController(StudentDbContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,marks1,marks2,marks3,marks4,marks5,marks6")] StudentViewModel studentViewModel)
        {
            if (ModelState.IsValid)
            {
                // Convert ViewModel to Model
                var student = new Student
                {
                    Name = studentViewModel.Name,
                    marks1 = studentViewModel.marks1,
                    marks2 = studentViewModel.marks2,
                    marks3 = studentViewModel.marks3,
                    marks4 = studentViewModel.marks4,
                    marks5 = studentViewModel.marks5,
                    marks6 = studentViewModel.marks6
                };

                _context.Add(student);
                await _context.SaveChangesAsync();

                // Redirect to the Index page after creation
                return RedirectToAction(nameof(Index));
            }

            return View(studentViewModel);
        }


        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var students = _context.Students.ToList();
                List<StudentViewModel> studentlist = students.Select(student => new StudentViewModel
                {
                    Id = student.Id,
                    Name = student.Name,
                    marks1 = student.marks1,
                    marks2 = student.marks2,
                    marks3 = student.marks3,
                    marks4 = student.marks4,
                    marks5 = student.marks5,
                    marks6 = student.marks6
                }).ToList();

                return View(studentlist);
            }
            catch (Exception ex)
            {
                // Log the exception and return an error view
                // _logger.LogError(ex, "An error occurred while fetching student data.");
                return View("Error"); // Ensure you have an Error view
            }
        }
    }
}
