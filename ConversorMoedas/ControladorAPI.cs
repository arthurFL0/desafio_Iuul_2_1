
using ConversorMoedas.Interfaces;

namespace ConversorMoedas
{
    internal class ControladorAPI
    {
        private Requester requester;

        public ControladorAPI(Requester r)
        {
            requester = r;
        }

        public async Task<float> converterValor(string moeda1, string moeda2, float valor)
        {
            IConversao obj = await requester.fazRequisicao(moeda1, moeda2);
            return obj.Taxa_conversao * valor;
        }
    }
}
