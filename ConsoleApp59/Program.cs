using System;
using System.Collections.Generic;

namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> impares = new List<int>();
            List<int> pares = new List<int>();
            Console.WriteLine("Numeros pares: ");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    pares.Add(i);
                    Console.Write(i + " - ");
                    alter(pares);
                }               
            }            
            Console.WriteLine("\nSetimo numero par entre 0 e 100 é " + pares[6]);
            Console.WriteLine("\nNumeros impares: ");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    impares.Add(i);
                    Console.Write(i + " - ");
                    alter(impares);
                }           
            }
            Console.WriteLine("\nVigésimo numero impar entre 0 e 100 é " + impares[19]);            
        }
        static void alter(List<int> list)
        {
            for (int i = 0; i <= list.Count -1; i++)
            {
                if (list[i] % 2 == 0)
                {
                    list[i] += 1;
                    list.Add(100);
                }
                else
                {
                    list[i] -= 1;                  
                }
                list.Remove(101);
            }
        }
    }
}
 