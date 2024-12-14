// Services/AdminService.cs
using System.Net.Http.Json;
using Proyecto_1.Server.Data;
using Proyecto_1.modelos;
public class AdminService
{
    private readonly HttpClient _httpClient;

    public AdminService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Admin>> GetAdminsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Admin>>("api/admin");
    }

    public async Task<Admin> GetAdminAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<Admin>($"api/admin/{id}");
    }

    public async Task CreateAdminAsync(Admin admin)
    {
        await _httpClient.PostAsJsonAsync("api/admin", admin);
    }

    public async Task UpdateAdminAsync(Admin admin)
    {
        await _httpClient.PutAsJsonAsync($"api/admin/{admin.Id}", admin);
    }

    public async Task DeleteAdminAsync(int id)
    {
        await _httpClient.DeleteAsync($"api/admin/{id}");
    }
}