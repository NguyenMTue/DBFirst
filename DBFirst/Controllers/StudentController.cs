using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DBFirst.Models; // Đảm bảo đúng namespace của dự án bạn

namespace DBFirst.Controllers.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext _context;

        // Tiêm (Inject) DbContext vào Controller thông qua Constructor
        public StudentController(StudentDbContext context)
        {
            _context = context;
        }

        // Action để hiển thị danh sách sinh viên
        public async Task<IActionResult> Index()
        {
            // Lấy toàn bộ danh sách sinh viên từ database
            var students = await _context.Students.ToListAsync();
            return View(students);
        }

        // Action để xem chi tiết 1 sinh viên
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
                
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
    }
}