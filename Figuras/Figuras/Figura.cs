using System;
namespace Figuras
{
    using System.Collections;
    public abstract class Figura
    {


        protected Figura(Punto p1) :
        this(new[] { p1 })
        {

        }

        protected Figura(Punto p1, Punto p2) :
        this(new[] { p1, p2 })
        {

        }


		protected Figura(int numPuntos)
		{
            this.puntos = new Punto[numPuntos];
		}


        protected Figura(Punto[] puntos) //protected porque es abstracta
        {
            this.puntos = puntos;
        }

        public abstract double CalculaArea();

        /*
        public ReadOnlyCollectionBase [] Puntos{

            get{
                
            }
        }*/


        private Punto[] puntos;
    }
}