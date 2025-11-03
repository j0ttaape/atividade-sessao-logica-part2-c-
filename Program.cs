using System.Security.Cryptography;

namespace atividade_sessao_logica_part2_c_
{
    class Program
    {
        static void Main(string[] args)
        {

            Apresentar();

            double gramas = PedirDados();
        }


        public static void Apresentar()
        {
            Console.WriteLine("PROGRAMA DO SORVETE");
        }

        public static double PedirDados()
        {
            Console.WriteLine("Me informe a quantidade em gramas desejada");

            double gramas = Convert.ToDouble(Console.ReadLine());

            return gramas;
        }

        public static double Calculos(double gramas)
        {

            double calculo = ((gramas / 100) * 3.5);
            double preco = 3.5;

            if (calculo >= 1000)
            {

                preco = 3;

            }
            else if (calculo < 1000)
            {
                
                
            }
        }

    }
}
