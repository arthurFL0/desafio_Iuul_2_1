using ConversorMoedas.Implementacoes;

namespace ConversorMoedas
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ControladorAPI c = new ControladorAPI(new ER_Requester());
            Console.WriteLine(await c.converterValor("USD", "BRL", 1));

        }
    }
}
