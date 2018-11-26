using System;

namespace Exercicio1
{
    class Program
    {
        static int meses;
        static double saldo, rendimento, fixa;
        public static void Calculadora(double saldo, double rendimento, int meses, double fixa)
        {
            double valorFixo = saldo * (fixa / 100);
            double saldoPoupanca = saldo, saldoFixo = saldo;
            double rendaFixa = 0;
            //calculo de rendimento poupança
            for (int i = 1; i <= meses; i++)
            {
                saldoPoupanca = saldoPoupanca + saldoPoupanca * (rendimento / 100);
            }
            saldoPoupanca = Math.Round(saldoPoupanca, 2);  //limitar casas decimais
            Console.WriteLine("Valor total rendido na poupança =  " + saldoPoupanca +  " reais");

            //calculo de rendimento renda fixa
            for (int i = 1; i <= meses; i++)
            {
                rendaFixa += valorFixo;
            }
            
            //calculo de imposto de renda sob renda fixa
            if(meses <= 12)
            {
                rendaFixa = rendaFixa * 0.75;
            }else if (meses >= 13 && meses <= 24)
            {
                rendaFixa = rendaFixa * 0.85;
            }else if (meses >= 25 && meses <= 36)
            {
                rendaFixa = rendaFixa * 0.95;
            }else {
                rendaFixa = rendaFixa * 0.99;
            }

            saldoFixo += rendaFixa;
            saldoFixo = Math.Round(saldoFixo, 2);  //limitar casas decimais
            Console.WriteLine("Valor total rendido na renda fixa =  " + saldoFixo + " reais");

            //apresentar melhor opção
            if (saldoPoupanca < saldoFixo)
            {
                Console.WriteLine("Investir em renda fixa é mais rentável");
            }
            else if (saldoPoupanca > saldoFixo)
            {
                Console.WriteLine("Investir em conta poupança é mais rentável");
            }
            else
            {
                Console.WriteLine("Os dois investimentos geram a mesma renda");
            }

        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Informar saldo da aplicação em poupança: ");
            saldo = double.Parse(Console.ReadLine()); 
            System.Console.WriteLine("Informar porcentagem de rendimento mensal da poupança: ");
            rendimento = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Informar porcentagem de renda fixa mensal: ");
            fixa = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Informar meses de rendimento: ");
            meses = int.Parse(Console.ReadLine());
            Calculadora (saldo, rendimento, meses, fixa);
            Console.ReadKey();
        }
    }
}