using System;
namespace DemoOperadores
{

    /**
     * 
     * ideone.com/baltasarq/dia
     * 
     * 
     * 
     * MAS EJEMPLOS------>SOBRECARGA
     * 
     * 
     */

    public class Complejo : IEquatable<Complejo> , IComparable<Complejo>
    {
        //se usa constructor por defecto



        /*sobrecargar los 2 metodos: equals hashcode*/
        /*multiplicar por numero primo*/
        public override int GetHashCode(){

            return this.Real.GetHashCode() 
                       + ( 11 * this.Imaginaria.GetHashCode());
        }

        public override bool Equals(object o){
            bool toret = false;

			/*OTRA FORMA
			 * if(o is Complejo){
                toret =( this.Real == ((Complejo)o).Real);
            }*/

			if (o is Complejo c)
			{
                //esta subrayado porque no hay precision para los valores reales
				toret = (this.Real == c.Real
                         && this.Imaginaria == c.Imaginaria);

                /*OTRA FORMA
                    usar compareTo
                */
			}

            return toret;
        }


        public  bool Equals(Complejo c2){

            return this.CompareTo(c2)==0;
        }

        public int CompareTo(Complejo c2){

            int toret = 0;

            if (this.Real != c2.Real
                || this.Imaginaria != c2.Imaginaria){

                if(this.Real <c2.Real){

                    toret = -1;

                }else{

                    toret = 1;
                }
            }
            return toret;
        }


        public static Complejo operator+(Complejo c1, Complejo c2){

            return new Complejo {Real= c1.Real + c2.Real , Imaginaria= c1.Imaginaria + c2.Imaginaria };
        }



        /*sobrecarga de == obliga a sobrecargar !=*/
        public static bool operator==(Complejo c1, Complejo c2){
            return c1.CompareTo(c2) == 0;
        }

		public static bool operator!=(Complejo c1, Complejo c2)
		{
            return !(c1 == c2);
		}

        public override string ToString()
        {
            return string.Format("{0:.00} {1:.00}i ", Real, Imaginaria);
        }
        public double Real{

            get;set;
        }

        public double Imaginaria{
            get;set;
        }
    }
}
