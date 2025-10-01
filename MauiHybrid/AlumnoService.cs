using System.Net.Http.Json;
using MauiHybrid; // tu clase Alumno existente

namespace MauiHybrid.Services
{
    public class AlumnoService
    {
        private readonly HttpClient _httpClient;

        private readonly string _baseUrl = "http://mauihybrid.somee.com/api/alumnos"; // API Somee#endif

        public AlumnoService()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(_baseUrl) };
        }

        public async Task<List<Alumno>> GetAlumnosAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Alumno>>("Alumnos") ?? new List<Alumno>();
        }

        public async Task<Alumno?> GetAlumnoByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Alumno>($"Alumnos/{id}");
        }

        public async Task<bool> AddAlumnoAsync(Alumno alumno)
        {
            var response = await _httpClient.PostAsJsonAsync("Alumnos", alumno);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAlumnoAsync(Alumno alumno)
        {
            var response = await _httpClient.PutAsJsonAsync($"Alumnos/{alumno.Id}", alumno);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAlumnoAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"Alumnos/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
