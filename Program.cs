using System;
using System.IO;

namespace sandia
{
    class Program
    {

        //programa con entrada/salida estandar
        static void Main(string[] args)
        {
            int peso;

            peso = Int32.Parse(Console.ReadLine());
            
            if (peso % 2 ==0 && peso !=2) {
                Console.WriteLine("YES");

            }
            else {
                Console.WriteLine("NO");
            }
        }
    }
}
