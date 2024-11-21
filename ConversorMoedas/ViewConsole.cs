using ConversorMoedas.Interfaces;
using static System.Console;
namespace ConversorMoedas
{
    internal class ViewConsole
    {
        Conversor conversor;


        public ViewConsole(Conversor c)
        {
            conversor = c;
        }


        public async Task RodarInterface()
        {
            while (true)
            {
                PedidoConversao p = LerDados();
                if (p.MoedaOrigem == "")
                {
                    break;
                }
                try
                {
                    IConversao c = await conversor.converterValor(p);
                    ImprimirInfo(p,c);
                }
                catch (Exception ex) {
                    WriteLine(ex.Message);
                }
            }

        }

        public PedidoConversao LerDados()
        {
            PedidoConversao? p = new PedidoConversao("", "", 0); 
            string mOrigem, mDestino;
            float valor;

            do
            {

                mOrigem = LerString("Moeda origem: ");
                if (mOrigem == "")
                    break;
                do
                {
                    if (Validador.moedaTemTresCarecteres(mOrigem)){
                        break;
                    }

                    WriteLine("Moeda origem precisa ter exatamente 3 caracteres");
                    mOrigem = LerString("Moeda origem: ");

                } while (true);


                do
                {
                    mDestino = LerString("Moeda destino: ");
                    if (Validador.moedaTemTresCarecteres(mDestino))
                    {
                        break;
                    }

                    WriteLine("Moeda destino precisa ter exatamente 3 caracteres");

                } while (true);
                do
                {
                    if (Validador.moedasSaoDiferentes(mOrigem, mDestino))
                    {
                        break;
                    }

                    WriteLine("Moedas destino e origem precisam ser diferentes");
                    mDestino = LerString("Moeda destino:");

                } while (true);

                do
                {
                    string input = LerString("Valor: ");
                    if (float.TryParse(input, out valor) && Validador.valorEhMaiorDoQueZero(valor))
                        break;

                    WriteLine("Valor precisa ser maior do que zero");
                } while (true);


                p = new PedidoConversao(mOrigem, mDestino, valor);
                break;

            }while (true);

            return p;


        }


        public void ImprimirInfo(PedidoConversao p, IConversao c)
        {
            WriteLine($"{p.MoedaOrigem} {p.Valor} => {p.MoedaDestino} {c.Valor_Convertido}");
            WriteLine($"Taxa: {c.Taxa_conversao}");
        }

        public string LerString(string msg)
        {
            Write(msg);
            string s = ReadLine() ?? "";
            s.Trim();
            return s;
        }
    }
}
