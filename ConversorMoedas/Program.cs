using ConversorMoedas.Implementacoes;

namespace ConversorMoedas
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ControladorAPI c = new ControladorAPI(new ER_Requester());
            ViewConsole vc = new ViewConsole(c);
            await vc.RodarInterface();

        }
    }
}
