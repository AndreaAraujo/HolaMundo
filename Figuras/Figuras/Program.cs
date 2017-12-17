using System;

namespace Figuras
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var P1 = new Punto ( 5.0, 5.0 );
            var P2= new Punto(7.0, 7.0);


            var rect = new Rectangulo(P1,P2);
            var circ = new Circulo(P1,8.0);

            Console.WriteLine("Area rectangulo"+rect.CalculaArea());
            Console.WriteLine("Area circulo" + circ.CalculaArea());
            Console.WriteLine("Area triangulo" + tria);
        }
    }
}
