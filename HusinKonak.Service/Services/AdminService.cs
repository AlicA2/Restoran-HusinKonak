using HusinKonak.Data;
using Microsoft.EntityFrameworkCore;
using HusinKonak.Services.Interface;

namespace HusinKonak.Services
{
    public class AdminService : IAdminService
    {
        private readonly RestaurantDBContext _context;

        public AdminService(RestaurantDBContext context)
        {
            _context = context;
        }

        public async Task<List<Admin>> GetAllAdmins()
        {
            return await _context.Admins.ToListAsync();
        }

        public async Task<Admin> GetAdminById(int id)
        {
            return await _context.Admins.FindAsync(id);
        }

        public async Task<int> AddAdmin(Admin admin)
        {
            _context.Admins.Add(admin);
            await _context.SaveChangesAsync();
            return admin.AdminId;
        }

        public async Task UpdateAdmin(int id, Admin admin)
        {
            if (id != admin.AdminId)
            {
                throw new ArgumentException("Id does not match.");
            }

            _context.Entry(admin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminExists(id))
                {
                    throw new ArgumentException("Admin not found.");
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task DeleteAdmin(int id)
        {
            var admin = await _context.Admins.FindAsync(id);
            if (admin == null)
            {
                throw new ArgumentException("Admin not found.");
            }

            _context.Admins.Remove(admin);
            await _context.SaveChangesAsync();
        }

        private bool AdminExists(int id)
        {
            return _context.Admins.Any(e => e.AdminId == id);
        }
    }
}