namespace atividade_sessao_logica_part2_c_;

class Program
{
    static void Main(string[] args)
    {
        Apresentar();
        
        Pedir();

        Quantidade();
        Calculo(tipo, qtd);

        Console.WriteLine($"O total a se pagar é {Calculo}");
    }

    public static void Apresentar()
    {
        Console.WriteLine("------------ PROGRAMA DO INGRESSO DO CINEMA ------------");

    }

    public static string Pedir ()
    {
        Console.WriteLine("Me informe qual tipo de ingresso você vai utilizar");
        string tipo = Convert.ToString(Console.ReadLine());
        return tipo;

    }

    public static int Quantidade ()
    {
        Console.WriteLine("Me informe a quantidade");
        int qtd = Convert.ToInt16(Console.ReadLine());
        return qtd;

    }

    public static double Calculo (string tipo, int qtd)
    {
        double resultado = 0;
        double meia = 14.25;
        
        double inteira = 28.5;
        
        if(tipo == "meia")
        {
            resultado = meia*qtd;
        }

        else if(tipo =="inteira")
        {
            resultado = inteira*qtd;
        }

        return resultado;

    }
}
