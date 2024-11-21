using ConversorMoedas.Implementacoes;

namespace ConversorMoedas
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Conversor c = new Conversor(new ER_Requester());
            ViewConsole vc = new ViewConsole(c);
            
            await vc.RodarInterface();

        }
    }
}
