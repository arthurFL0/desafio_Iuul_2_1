
namespace ConversorMoedas
{
    internal static class Validador
    {
        public static bool moedasSaoDiferentes(string a, string b)
        {
            return a != b;
        }

        public static bool moedaTemTresCarecteres(string moeda)
        {
            return moeda.Length == 3;
        }

        public static bool valorEhMaiorDoQueZero(float valor)
        {
            return valor > 0;
        }
    }
}
