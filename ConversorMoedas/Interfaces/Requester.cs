namespace ConversorMoedas.Interfaces
{
    internal interface Requester
    {
        public Task<IConversao> fazRequisicao(string moeda1, string moeda2);
    }
}
