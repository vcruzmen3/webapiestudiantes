using Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{

        [Route("api/[controller]")]
        [ApiController]
        public class TeacherController  : ControllerBase
    {
        private readonly DbContextSchool _db;

        public TeacherController(DbContextSchool db) 
        { 
            _db=db;
        }

        [HttpGet]
        public async Task<IActionResult> GetTeachers()
        {
            var lista = await _db.Teachers.OrderBy(c => c.Name).ToListAsync();
            return Ok(lista);
        }
    }
}
