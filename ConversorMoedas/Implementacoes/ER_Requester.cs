
using System.Text.Json;
using ConversorMoedas.Interfaces;

namespace ConversorMoedas.Implementacoes
{
    internal class ER_Requester : Requester
    {


        public async Task<IConversao> fazRequisicao(string moeda1, string moeda2)
        {

            HttpClient c = new HttpClient();
            string jsonString;
            ObjetoER? obj;
            var response = await c.GetAsync($"https://v6.exchangerate-api.com/v6/156b8f82cb3e5f48a65de0c1/pair/{moeda1}/{moeda2}");
            if (response == null)
                throw new Exception("Erro na comunicação com a API");

            jsonString = await response.Content.ReadAsStringAsync();
            obj = JsonSerializer.Deserialize<ObjetoER>(jsonString, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            if (obj == null)
                throw new Exception("Erro no tratamento da requisição");

            if (!response.IsSuccessStatusCode)
            {
                if (obj.ErroType == "unknown-code")
                    throw new Exception("Erro na Cominucação com a API. Código da Moeda inválido");

                throw new Exception("Erro na comunicação com a API");
            }


            return obj;
        }
    }
}
