using System;

namespace calculadora
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string calculos = Console.ReadLine();

            var calc = new Calculadora(calculos);
            Console.WriteLine("resulltado: " + calc.Resultado);
        }
    }
}
