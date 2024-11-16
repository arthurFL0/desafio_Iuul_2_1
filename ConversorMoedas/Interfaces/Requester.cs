namespace ConversorMoedas.Interfaces
{
    internal interface Requester
    {
        public Task<IConversao> fazerRequisicao(PedidoConversao p);
    }
}
