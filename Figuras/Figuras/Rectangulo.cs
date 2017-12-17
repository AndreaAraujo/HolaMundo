using System;
namespace Figuras
{
    public class Rectangulo :Figura
    {

        public Punto P1
        {

            get; set;
        }

        public Punto P2
        {
            get; set;
        }


        public Rectangulo(Punto p1,double distancia1, double distancia2)

            :base(p1,p1.sumaDistancias(distancia1,distancia2)){

        }
        /*
        public Rectangulo(Punto p1, Punto p2)
        {
            this.P1 = p1;
            this.P2 = p2;
            
        }*/

		public Rectangulo(Punto p1, Punto p2)
            :base(p1,p2)
		{
			

		}



        public override double CalculaArea()
		{
            return (Math.Abs(P1.X -P2.X)* Math.Abs(P1.Y-P2.Y));	
		}
    }
}
