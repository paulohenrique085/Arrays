using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           



        }





        static void TestaArray()
        {
            //criando array
            int[] idades = new int[5];

            idades[0] = 20;
            idades[1] = 18;
            idades[2] = 21;
            idades[3] = 20;
            idades[4] = 16;
            //variavel para acumular soma de idades
            int acumulador = 0;
            int media;
            for (int i = 0; i < idades.Length; i++)
            {
                int idade = idades[i];
                acumulador = acumulador + idade;
            }

            media = acumulador / idades.Length; //---->Length=tamanho;
            Console.WriteLine(media);

        }
        static void InicializandoArrayDeObjetos()
        {
            //inicialização de arrays 
            ContaCorrente[] contas = new ContaCorrente[] {

                 new ContaCorrente("PAULO",1160397,1234),
                 new ContaCorrente("MARINA", 1158968, 1234),
                 new ContaCorrente("MARIANA", 87899632, 1234)
            };


            for (int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine($"Conta no indice [{i}] Titular:{contas[i].Titular} Conta: {contas[i].NumeroConta} Agência: {contas[i].NumeroAgencia}");

            }
        }
    }
}
