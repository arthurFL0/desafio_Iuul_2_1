
namespace ConversorMoedas
{
    internal class PedidoConversao
    {
        public string MoedaOrigem { get; }
        public string MoedaDestino { get; }

        public float Valor {  get; }
        public PedidoConversao(string mOrigem, string mDestino, float valor) {
            MoedaOrigem = mOrigem;
            MoedaDestino = mDestino;
            Valor = valor;
        }

        
    }
}
