using Microsoft.AspNetCore.Mvc;
using HusinKonak.Data;
using HusinKonak.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using RestoranApp_HusinKonak.ViewModels;

namespace HusinKonak.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;
        private readonly RestaurantDBContext _dbContext;

        public AdminController(RestaurantDBContext dbContext, IAdminService adminService)
        {
            _dbContext = dbContext;
            _adminService = adminService;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] LoginModel adminObj)
        {
            if (adminObj == null)
                return BadRequest();

            var user = await _dbContext.Admins
                .FirstOrDefaultAsync(x => x.Name == adminObj.Name && x.Password == adminObj.Password );

            if (user == null)
                return NotFound(new { Message = "User not found!" });

            return Ok(new { Message = "Login success" });
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] Admin adminObj)
        {
            if (adminObj == null)
                return BadRequest();

            await _dbContext.Admins.AddAsync(adminObj);
            await _dbContext.SaveChangesAsync();

            return Ok(new { Message = "User Registered!" });
        }

        [HttpGet]
        public async Task<IActionResult> GetAdmins()
        {
            var admins = await _adminService.GetAllAdmins();
            return Ok(admins);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Admin>> GetAdmin(int id)
        {
            var admin = await _adminService.GetAdminById(id);

            if (admin == null)
                return NotFound();

            return admin;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdmin(int id, [FromBody] Admin admin)
        {
            if (id != admin.AdminId)
                return BadRequest();

            await _adminService.UpdateAdmin(id, admin);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Admin>> PostAdmin([FromBody] Admin admin)
        {
            await _adminService.AddAdmin(admin);

            return CreatedAtAction("GetAdmin", new { id = admin.AdminId }, admin);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            var admin = await _adminService.GetAdminById(id);
            if (admin == null)
                return NotFound();

            await _adminService.DeleteAdmin(admin.AdminId);

            return NoContent();
        }
    }
}