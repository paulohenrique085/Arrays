using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class ContaCorrente
    {
        public string Titular { get; set; }
        public int NumeroConta { get;}
        public int NumeroAgencia { get; }

        public ContaCorrente()
        {

        }
        public ContaCorrente(string titular, int numeroConta, int numeroAgencia)
        {
            Titular = titular;
            NumeroConta = numeroConta;
            NumeroAgencia = numeroAgencia;
        }
    }
}
