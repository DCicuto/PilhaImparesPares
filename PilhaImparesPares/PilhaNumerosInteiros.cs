using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaImparesPares
{
    internal class PilhaNumerosInteiros
    {
        NumeroInteiro Topo;
        public PilhaNumerosInteiros()
        {
            Topo = null;
        }

        public void Push(NumeroInteiro aux)
        {
            if (Vazia())
                Topo = aux;
            else
            {
                aux.SetAnterior(Topo);
                Topo = aux;
            }
        }
        bool Vazia()
        {
            if (Topo == null)
                return true;
            else
                return false;
        }
        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("\nPilha vazia! Impossivel remover!");
                Console.WriteLine("Pressione qualquer tecla para continuuar...\n\n");
                Console.ReadKey();
            }
            else
                Topo = Topo.GetAnterior();
        }

        public int Contador()
        {
            int quantidadeElementos = 0;
            NumeroInteiro aux = Topo;

            if (Vazia())
            {
                Console.WriteLine("\nPilha vazia! Impossivel remover!");
                Console.WriteLine("Pressione qualquer tecla para continuuar...\n\n");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    aux = aux.GetAnterior();
                    quantidadeElementos++;
                } while (aux != null);
            }

            return quantidadeElementos;
        }

        public int GetMaior()
        {
            int numeroMaior = 0;
            NumeroInteiro aux = Topo;

            do
            {
                if (aux.GetNumero() > numeroMaior)
                {
                    numeroMaior = aux.GetNumero();
                }
                aux = aux.GetAnterior();
            }while (aux != null);

            return numeroMaior;
        }

        public int GetMenor()
        {
            int numeroMenor = 100;
            NumeroInteiro aux = Topo; 
            
            do
            {
                if (aux.GetNumero() < numeroMenor){
                    numeroMenor = aux.GetNumero();
                }
                aux = aux.GetAnterior();
            }while(aux != null);

            return numeroMenor;
        }

        public double GetMedia(int tamanho)
        {
            double media = 0;
            NumeroInteiro aux = Topo;

            do
            {
                media = media + aux.GetNumero();
                aux = aux.GetAnterior();
            }while (aux != null);

            media = media / tamanho;
            return media;
        }

        public void GetImpar(string nomePilha)
        {
            int contador = 0;
            NumeroInteiro aux = Topo;

            do
            {
                if (aux.GetNumero() % 2 != 0)
                {
                    Console.WriteLine("Numero impar: " + aux.GetNumero());
                    contador++;
                }
                aux = aux.GetAnterior();
            } while(aux != null);

            Console.WriteLine("A quantidade de numeros impares na " + nomePilha + " é: " + contador + "\n\n");
        }

        public void GetPar(string nomePilha)
        {
            int contador = 0;
            NumeroInteiro aux = Topo;

            do
            {
                if (aux.GetNumero() % 2 == 0)
                {
                    Console.WriteLine("Numero Par: " + aux.GetNumero());
                    contador++;
                }
                aux = aux.GetAnterior();
            } while (aux != null);

            Console.WriteLine("A quantidade de numeros pares na " + nomePilha + " é: " + contador + "\n\n");
        }
    }
}

