using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiti_Vacanze
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a);  //Stampa il valore massimo positivo rappresentabile in 32bit
            if (a + 1 < -int.MaxValue)
            {
                Console.WriteLine(a + 1);  //Stampa il valore minimo negativo rappresentabile in 32 bit
            }
            int b = -128;  //Associa alla variabile b il valore -128
            int c = -b;  //Associa alla variabile c il valore -b
            Console.WriteLine(Convert.ToString(b, 2));  //Stampa in binario il valore -128
            Console.WriteLine(Convert.ToString(c, 2));  //Stampa in binario il valore 128
            int value = 31;
            int somma = value;
            value = ~value + 1; //NOT
            //value = value + 1;
            somma = somma + value;
            Console.WriteLine($"{value} e {somma}");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2));
            short number1 = (short)number;
            Console.WriteLine(number1);

            Console.ReadLine();
        }
    }
}
