using System;
using System.Globalization;
namespace calculadora
{
    public class Calculadora
    {
        public Calculadora(string input)
        {
            this.Operandos = input.Split();
            this.Calcula();
           //this.Resultado = 0;
        }

        private void Calcula()
        {

            double op1 = System.Convert.ToDouble(this.Operandos[0], CultureInfo.InvariantCulture);
            char opr = this.Operandos[1].Trim()[0];
            double op2 = System.Convert.ToDouble(this.Operandos[2], CultureInfo.InvariantCulture); //evita error de la , vs . de los double


            switch(opr){

                case '+' : this.Resultado = op1 + op2; break;
                    case '-': this.Resultado = op1 - op2; break;
                    case '/': this.Resultado = op1 / op2; break;
                    case '*': this.Resultado = op1 * op2; break;

            }
        }

        public double Resultado{

            get;private set;

        }

        public string[] Operandos {

            get;private set;
        }
    }
}
