using BloodBank.Shared.Entidades;

namespace BloodBank.WEB.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWrapper<T>> GetAsync<T>(string url);

        Task<HttpResponseWrapper<object>> PostAsync<T>(string url, T model);

        Task<HttpResponseWrapper<TResponse>> PostAsync<T, TResponse>(string url, T model);

        Task<HttpResponseWrapper<object>> PutAsync<T>(string url, T model);

        Task<HttpResponseWrapper<TResponse>> PutAsync<T, TResponse>(string url, T model);

        Task<HttpResponseWrapper<object>> DeleteAsync<T>(string url);
        Task<HttpResponseWrapper<List<Donante>>> GetDonantesAsync();
        Task<HttpResponseWrapper<List<Enfermero>>> GetEnfermerosAsync();
        Task<HttpResponseWrapper<List<Hospital>>> GetHospitalesAsync();
        Task<HttpResponseWrapper<List<Inventario>>> GetInventariosAsync();
        Task<HttpResponseWrapper<List<Cita>>> GetCitasAsync();





    }
}
