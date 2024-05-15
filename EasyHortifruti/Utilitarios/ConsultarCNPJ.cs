using System;
using System.Net.Http;
using System.Threading.Tasks;
using EasyHortifruti.DML;
using Newtonsoft.Json;

namespace EasyHortifruti.Utilitarios
{
    public static class ConsultarCNPJ
    {
        public static async Task<CNPJConsultado> ConsCNPJ(string cnpj)
        {
            string url = "https://publica.cnpj.ws/cnpj/" + cnpj;

            try
            {
                var dados = await new ApiClient().GetDadosAsync(url);

                return CNPJConsultado.FromJson(dados.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
