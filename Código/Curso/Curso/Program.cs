using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            bool completo = false;
            char genero = 'F';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 342879182;
            long n4 = 1284892175829345L;
            char letra = '\u0041';
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria";
            object obj1 = "Diego";
            object obj2 = 4.5f;

            int m1 = int.MinValue;
            int m2 = int.MaxValue;

            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            sbyte m3 = sbyte.MaxValue;
            Console.WriteLine(m3);
            decimal m4 = decimal.MaxValue;
            Console.WriteLine(m4);

        }
    }
}
