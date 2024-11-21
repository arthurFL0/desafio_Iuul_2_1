
using ConversorMoedas.Interfaces;

namespace ConversorMoedas
{
    internal class Conversor
    {
        private Requester requester;

        public Conversor(Requester r)
        {
            requester = r;
        }

        public async Task<IConversao> converterValor(PedidoConversao p)
        {
            IConversao obj = await requester.fazerRequisicao(p);
            return obj;
        }
    }
}
