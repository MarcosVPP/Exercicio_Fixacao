using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosApostila
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio01();
            Exercicio02();
            Exercicio03();
            Exercicio04();
            Exercicio05();
            Exercicio06();
        }
        public static void Exercicio01()
        {
            Console.WriteLine("EXERCICIO 01");
            int total = 2;
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }


            Console.Write(total);
            Console.WriteLine();
        }
        public static void Exercicio02()
        {
            Console.WriteLine("EXERCICIO 02");
            int somatorio = 0;
            
            for (int i = 1; i <= 3; i++)
            {
                somatorio = somatorio + i;
            }

            Console.Write(somatorio);
            Console.WriteLine();
        }
        public static void Exercicio03()
        {
            Console.WriteLine("EXERCICIO 03");

            
            for (int i = 1; i <100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
        }
        public static void Exercicio04()
        {
            Console.WriteLine("EXERCICIO 04");

            int numero = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    numero += i;
                }
                
            }
            Console.Write(numero);
            Console.WriteLine();
        }
        public static void Exercicio05()
        {
            Console.WriteLine("EXERCICIO 05");

            for (int i = 1; i < 30; i++)
            {
                if((i % 3 == 0)||(i% 4== 0))
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
        }
        public static void Exercicio06()

        {
            Console.WriteLine("EXERCICIO 06");
            int fatorial= 10;

            for (int i = fatorial - 1; i > 1; i--)
            {
                fatorial *= i;
            }

            Console.WriteLine(fatorial);
            Console.ReadLine();
        }

    }
}
