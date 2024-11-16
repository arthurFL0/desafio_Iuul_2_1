
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

        public async Task<IConversao> converterValorComAPI(PedidoConversao p)
        {
            IConversao obj = await requester.fazerRequisicao(p);
            return obj;
        }
    }
}
