using System.Xml.XPath;

internal class Program
{
    private static void Main(string[] args)
    {
        //Calculadora do Vitor
        Console.WriteLine("Escolha a Operação");

        //Escolher as opções para a conta
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        Console.WriteLine("Escolha uma opção de 1 a 4: ");

        //Criei uma Variavel para armazenar a operação
        int operacao = int.Parse(Console.ReadLine());

        //Criei uma variavel para receber o numero do usuario
        Console.WriteLine("Digite o primeiro número:\n");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:\n");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = 0;

        switch (operacao)
        {
            case 1:
            {
                resultado = Adicao(num1, num2);
                break;
            }
            case 2:
            {
                resultado = Subtracao(num1, num2);
                break;
            }
            case 3:
            {
                resultado = Multiplicacao(num1, num2);
                break;
            }
            case 4:
            {
                resultado = Divisao(num1, num2);
                break;
            }
            default:
            {
                Console.WriteLine("Número invalido! ");
                break;
            }
        }
        Console.WriteLine("O resultado da operação de {0} e {1} é: {2}",num1, num2, resultado);
        Console.ReadLine();
    }
        public static int Adicao(int numero1, int numero2)
        {
            int result = numero1 + numero2;
            return result;
        }
        public static int Subtracao(int numero1, int numero2)
        {
            int result = numero1 - numero2;
            return result;
        }
        public static int Multiplicacao (int numero1, int numero2)
        {
            int result = numero1 * numero2;

            return result;
        }
        public static int Divisao(int numero1, int numero2)
        {
            int result = numero1 / numero2;
            return result;
        }
}