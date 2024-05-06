using PilhaImparesPares;
using System.Security.Cryptography;

namespace PilhaDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaNumerosInteiros p1 = new PilhaNumerosInteiros();
            PilhaNumerosInteiros p2 = new PilhaNumerosInteiros();
            int opcao = 0;

            do
            {
                //Console.Clear();
                Console.WriteLine(">>> Menu Principal - Pilha de Numeros Inteiros <<<");
                Console.WriteLine("Escolha uma das opções:\n" +
                                  "1 - Adcionar numeros a p1;\n" +
                                  "2 - Adcionar numeros a p2;\n" +
                                  "3 - Testas se p1 e p2 possuem o mesmo tamanho;\n" +
                                  "4 - Para exibir o numero maior e menor e a media;\n" +
                                  "5 - Para exibir Numeros Impares;\n" +
                                  "6 - Para exibir Numeros Pares;\n" +
                                  "7 - Trocar elementos de pilha;\n" + 
                                  "0 - Sair");

                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        p1.Push(AdcionarNumero());
                        break;
                    case 2:
                        p2.Push(AdcionarNumero());
                        break;
                    case 3:
                        CompararPilhas(p1,p2);
                        break;
                    case 4:
                        MostrarMedia(p1);
                        MostrarMedia(p2);
                        break;
                    case 5:
                        p1.GetImpar("pilha 1");
                        p2.GetImpar("pilha 2");
                        break;
                    case 6:
                        p1.GetPar("pilha 1");
                        p2.GetPar("pilha 2");
                        break;
                    case 0:
                        Console.WriteLine("Fim do Programa;");
                        break;
                    default:
                        Console.WriteLine("Opção inexistente!");
                        break;
                }
            } while (opcao != 0);
        }

        static NumeroInteiro AdcionarNumero()
            {
                int numero;
                Console.WriteLine("Informe um numero inteiro:");
                numero = int.Parse(Console.ReadLine());
                NumeroInteiro numeroInteiro = new NumeroInteiro(numero);
                return numeroInteiro;
            }

        static void CompararPilhas(PilhaNumerosInteiros pilha1, PilhaNumerosInteiros pilha2)
        {
            int numeros1 = pilha1.Contador();
            int numeros2 = pilha2.Contador();

            if (numeros1 == numeros2)
                Console.WriteLine($"P1 e P2 são iguais e possuem {numeros1} Números;\n\n");
            else if (numeros1 > numeros2)
                Console.WriteLine($"A P1 é maior que P2 e possuem {numeros1} números;\n\n");
            else
                Console.WriteLine($"A P2 é maior que P1 e possuem {numeros2} números;\n\n");
        }
        
        static void MostrarMedia(PilhaNumerosInteiros pilha)
        {
            if (pilha.Contador() == 1)
            {
                Console.WriteLine("Por favor insira mais de um número da pilha");
                AdcionarNumero();
            }

            Console.WriteLine("O número maior é: " + pilha.GetMaior());
            Console.WriteLine("O número menor é: " + pilha.GetMenor());
            Console.WriteLine("A média de números é: " + pilha.GetMedia(pilha.Contador()) + "\n\n");
        }

        
    }
}