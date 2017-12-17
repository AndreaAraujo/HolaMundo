using System;
namespace Figuras
{
    public class Triangulo: Figura
    {
		public Punto P1
		{
			get; set;
		}

		public Punto P2
		{
			get; set;
		}

		public Punto P3
		{
			get; set;
		}

        /*
        public Triangulo(Punto P1, Punto P2,Punto P3)
        {
            this.P1 = P1;
            this.P2 = P2;
            this.P3 = P3;
        }*/

        public Triangulo(Punto P1, Punto P2, Punto P3)
            :base(new []{P1,P2,P3})
        { 
        }

        public override double CalculaArea(){

            Punto nuevo1 = new Punto(Math.Min(Math.Min(P1.X, P2.X), P3.X), Math.Min(Math.Min(P1.Y, P2.Y), P3.Y));
            Punto nuevo2 = new Punto(Math.Max(Math.Max(P1.X, P2.X),P3.X), Math.Max(Math.Max(P1.Y, P2.Y), P3.Y));

            return (Math.Abs(nuevo1.X-nuevo2.X) * Math.Abs(nuevo1.Y-nuevo2.Y)) / 2;

        }
    }
}
