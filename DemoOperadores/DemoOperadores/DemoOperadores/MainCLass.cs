using System;
namespace DemoOperadores
{
    public class MainCLass
    {
        public static void Main()
        {
            var c1 =new Complejo { Real = 5, Imaginaria = 6 };
            var c2 = new Complejo { Real = 1, Imaginaria = 2};

            Console.WriteLine("Complejo");
            Console.WriteLine(c1);
			Console.WriteLine(c2);
			Console.WriteLine(c1+c2);
        }
    }
}
