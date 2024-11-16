

using System.Text.Json.Serialization;
using ConversorMoedas.Interfaces;

namespace ConversorMoedas.Implementacoes
{
    internal class ObjetoER : IConversao
    {
        public string? result { get; set; }

        [JsonPropertyName("error-type")]
        public string? ErroType { get; set; }

        [JsonPropertyName("conversion_rate")]
        public float Taxa_conversao { get; set; }

        [JsonPropertyName("conversion_result")]
        public float Valor_Convertido { get; set; }
    }
}
