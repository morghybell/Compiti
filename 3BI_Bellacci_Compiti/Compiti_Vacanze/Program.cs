﻿using System;
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
            int value = Convert.ToInt32(Console.ReadLine());
            int somma = value;
            value = ~value + 1; //NOT
            //value = value + 1;
            somma = somma + value;
            Console.WriteLine($"L'opposto del valore da lei inserito è {value} e la somma del valore iniziale con il suo opposto è {somma}");
            long number = 55555;  //Associa alla variabile number il valore 55555
            Console.WriteLine(Convert.ToString(number, 2));  //Stampa in binario il valore 55555
            short number1 = (short)number;  //Associa il valore della variabile number di tipo long alla variabile number1 di tipo short convertendolo.
            Console.WriteLine(number1);  //Stampa il valore di tipo short ottenuto

            Console.ReadLine();
        }
    }
}
