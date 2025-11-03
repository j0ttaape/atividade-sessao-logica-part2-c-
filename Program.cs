namespace atividade_sessao_logica_part2_c_
{
    class Program
    {
        static void Main(string[] args)
        {

            Apresentar();

            string mes = PedirDados();


        }


        public static void Apresentar()
        {
            Console.WriteLine("PROGRAMA DOS MESES");
        }

        public static string PedirDados()
        {
            Console.WriteLine("Me informe o mês em número (exexmplo: 2 = fevereirio)");

            string mes = Console.ReadLine();

            return mes;
        }

        public static string Verificacao(string mes)
        {
            if()
        }
    }
}
