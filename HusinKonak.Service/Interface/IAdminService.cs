using HusinKonak.Data;

namespace HusinKonak.Services.Interface
{
    public interface IAdminService
    {
        Task<List<Admin>> GetAllAdmins();
        Task<Admin> GetAdminById(int id);
        Task<int> AddAdmin(Admin admin);
        Task UpdateAdmin(int id, Admin admin);
        Task DeleteAdmin(int id);
    }
}