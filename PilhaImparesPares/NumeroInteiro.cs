using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaImparesPares
{
    internal class NumeroInteiro
    {
        int Numero;
        NumeroInteiro Anterior;

        public NumeroInteiro(int numero)
        {
            this.Numero = numero;
            this.Anterior = null;
        }

        public void SetAnterior(NumeroInteiro numeroInteiro)
        {
            Anterior = numeroInteiro;
        }
        
        public NumeroInteiro GetAnterior()
        {
            return Anterior;
        }

        public int GetNumero()
        {
            return Numero;
        }


    }
}
