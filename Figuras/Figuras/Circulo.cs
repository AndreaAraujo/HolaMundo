using System;
namespace Figuras
{
    public class Circulo:Figura
    {
        public Punto P{
            get;set;
        }

       
        public double radio{

            get;set;
        }

        public Circulo(Punto p1,  Punto p2):
        this(p1, p1.Distancia(p2))
        {
        }
        public Circulo(Punto p1,double radio)
        {
            this.P = p1;
            this.radio = radio;
        }

        public double CalculaArea(){

            return Math.PI * (radio*radio);
        }
    }
}
