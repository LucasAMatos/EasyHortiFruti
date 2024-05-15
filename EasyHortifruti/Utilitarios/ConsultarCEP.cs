using EasyHortifruti.DML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyHortifruti.Utilitarios
{
    public static class ConsultarCEP
    {
        public static async Task<CEPConsultado> ConsCEP(string cep)
        {
            string url = string.Format("http://viacep.com.br/ws/{0}/json/", cep);

            try
            {
                var dados = await new ApiClient().GetDadosAsync(url);

                return CEPConsultado.FromJson(dados.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
