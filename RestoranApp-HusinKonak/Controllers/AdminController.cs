using Microsoft.AspNetCore.Mvc;
using HusinKonak.Data;
using HusinKonak.Services.Interface;

namespace HusinKonak.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        // GET: api/Admin
        [HttpGet]
        public async Task<IActionResult> GetAdmins()
        {
            var admins = await _adminService.GetAllAdmins();
            return this.Ok(admins);
        }

        // GET: api/Admin/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Admin>> GetAdmin(int id)
        {
            var admin = await _adminService.GetAdminById(id);

            if (admin == null)
            {
                return NotFound();
            }

            return admin;
        }

        // PUT: api/Admin/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdmin(int id, Admin admin)
        {
            if (id != admin.AdminId)
            {
                return BadRequest();
            }

            await _adminService.UpdateAdmin(id,admin);

            return NoContent();
        }

        // POST: api/Admin
        [HttpPost]
        public async Task<ActionResult<Admin>> PostAdmin(Admin admin)
        {
            await _adminService.AddAdmin(admin);

            return CreatedAtAction("GetAdmin", new { id = admin.AdminId }, admin);
        }

        // DELETE: api/Admin/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            var admin = await _adminService.GetAdminById(id);
            if (admin == null)
            {
                return NotFound();
            }

            await _adminService.DeleteAdmin(admin.AdminId);

            return NoContent();
        }
        //dodan komentar test
    }
}