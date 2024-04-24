using System;
using System.Net.Http;
using System.Threading.Tasks;
using EasyHortifruti.DML;
using Newtonsoft.Json;

namespace EasyHortifruti.Utilitarios
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<object> GetDadosAsync(string url)
        {
            try
            {
                // Fazendo a requisição à API e obtendo a resposta
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                // Verificando se a resposta é bem-sucedida (código 200)
                if (response.IsSuccessStatusCode)
                {
                    // Lendo o conteúdo da resposta como uma string
                    string json = await response.Content.ReadAsStringAsync();

                    // Desserializando o JSON em um objeto
                    var dados = JsonConvert.DeserializeObject<object>(json);

                    return dados;
                }
                else
                {
                    // Se a resposta não for bem-sucedida, lançar uma exceção com o código de status
                    throw new Exception($"Erro na requisição: {response.StatusCode}");
                }
            }
            catch (Exception e)
            {
                // Tratamento de exceção em caso de erros na requisição
                throw new Exception($"Erro durante a requisição: {e.Message}");
            }
        }
    }
}
