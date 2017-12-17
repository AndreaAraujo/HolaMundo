using System;
namespace Figuras
{
    public class Punto
    {
        public double X{
            get;set;
        }
        public double Y{
            get;set;
        }


        public Punto(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }


        public Punto sumaDistancias(double distancia1, double distancia2){

            double valor1 = this.X + distancia1;
            double valor2 = this.Y + distancia2;

            return new Punto(valor1, valor2);
        }

        public double Distancia(Punto p2){

            double c1 = this.X - p2.X;
            double c2 = this.Y - p2.Y;

            return System.Math.Sqrt((c1 * c2) + (c2 * c2));

        }
    }
}
