using System.Text.Json;

namespace ScreenSound04
{
    public static class ClientApi<T> where T : class
    {
        public static async Task<IEnumerable<T>> Listar(T entidade, string endpoint)
        {
            using (HttpClient client = new HttpClient())
            {
                string resposta = await client.GetStringAsync(endpoint);
                var listaEntidades = JsonSerializer.Deserialize<List<T>>(resposta);
                return listaEntidades ?? Enumerable.Empty<T>();
            }
        }
    }
}
