using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoctelesApiPO
{
    public class CocktailServicePO
    {
        private readonly HttpClient _httpClient;

        // Constructor: Inicializa el HttpClient
        public CocktailServicePO()
        {
            _httpClient = new HttpClient();
        }

        // Método asincrónico para obtener los cócteles desde la API
        public async Task<List<Cocktail>> ObtenerCocktails(string nombre)
        {
            // URL de la API con el parámetro de búsqueda
            var url = $"https://www.thecocktaildb.com/api/json/v1/1/search.php?s={nombre}";

            try
            {
                // Realizar la solicitud HTTP GET
                var response = await _httpClient.GetStringAsync(url);

                // Deserializar la respuesta JSON en un objeto CocktailResponse
                var cocktailResponse = JsonConvert.DeserializeObject<CocktailResponse>(response);

                // Devolver la lista de cócteles
                return cocktailResponse?.Drinks;
            }
            catch (Exception ex)
            {
                // Manejar errores de la solicitud
                Console.WriteLine($"Error al obtener los cócteles: {ex.Message}");
                return null;
            }
        }
    }
}
